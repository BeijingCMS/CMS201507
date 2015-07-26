﻿using System;
using System.Linq;
using System.Web.Mvc;
using SSOA.Admin.Extensions;
using SSOA.Admin.Models.Topics;
using SSOA.Core.Domain.Topics;
using SSOA.Services.Localization;
using SSOA.Services.Security;
using SSOA.Services.Seo;

using SSOA.Services.Topics;
using SSOA.Web.Framework.Controllers;
using SSOA.Web.Framework.Kendoui;

namespace SSOA.Admin.Controllers
{
    public partial class TopicController : BaseAdminController
    {
        #region Fields

        private readonly ITopicService _topicService;
        private readonly ILanguageService _languageService;
        private readonly ILocalizedEntityService _localizedEntityService;
        private readonly ILocalizationService _localizationService;
        private readonly IPermissionService _permissionService;
        
        
        private readonly IUrlRecordService _urlRecordService;
        private readonly ITopicTemplateService _topicTemplateService;

        #endregion Fields

        #region Constructors

        public TopicController(ITopicService topicService,
            ILanguageService languageService,
            ILocalizedEntityService localizedEntityService, 
            ILocalizationService localizationService,
            IPermissionService permissionService, 
            IUrlRecordService urlRecordService,
            ITopicTemplateService topicTemplateService)
        {
            this._topicService = topicService;
            this._languageService = languageService;
            this._localizedEntityService = localizedEntityService;
            this._localizationService = localizationService;
            this._permissionService = permissionService;
            
            
            this._urlRecordService = urlRecordService;
            this._topicTemplateService = topicTemplateService;
        }

        #endregion
        
        #region Utilities

        [NonAction]
        protected virtual void PrepareTemplatesModel(TopicModel model)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            var templates = _topicTemplateService.GetAllTopicTemplates();
            foreach (var template in templates)
            {
                model.AvailableTopicTemplates.Add(new SelectListItem
                {
                    Text = template.Name,
                    Value = template.Id.ToString()
                });
            }
        }

        [NonAction]
        protected virtual void UpdateLocales(Topic topic, TopicModel model)
        {
            foreach (var localized in model.Locales)
            {
                _localizedEntityService.SaveLocalizedValue(topic,
                                                               x => x.Title,
                                                               localized.Title,
                                                               localized.LanguageId);

                _localizedEntityService.SaveLocalizedValue(topic,
                                                           x => x.Body,
                                                           localized.Body,
                                                           localized.LanguageId);

                _localizedEntityService.SaveLocalizedValue(topic,
                                                           x => x.MetaKeywords,
                                                           localized.MetaKeywords,
                                                           localized.LanguageId);

                _localizedEntityService.SaveLocalizedValue(topic,
                                                           x => x.MetaDescription,
                                                           localized.MetaDescription,
                                                           localized.LanguageId);

                _localizedEntityService.SaveLocalizedValue(topic,
                                                           x => x.MetaTitle,
                                                           localized.MetaTitle,
                                                           localized.LanguageId);

                //search engine name
                var seName = topic.ValidateSeName(localized.SeName, localized.Title, false);
                _urlRecordService.SaveSlug(topic, seName, localized.LanguageId);
            }
        }

        [NonAction]
        protected virtual void PrepareStoresMappingModel(TopicModel model, Topic topic, bool excludeProperties)
        {
            if (model == null)
                throw new ArgumentNullException("model");

            
            if (!excludeProperties)
            {
                if (topic != null)
                {
                    
                }
            }
        }

        [NonAction]
        protected virtual void SaveStoreMappings(Topic topic, TopicModel model)
        {
           
        }

        #endregion
        
        #region List

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            var model = new TopicListModel();
            //stores
            model.AvailableStores.Add(new SelectListItem { Text = _localizationService.GetResource("Admin.Common.All"), Value = "0" });
            
            return View(model);
        }

        [HttpPost]
        public ActionResult List(DataSourceRequest command, TopicListModel model)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            var topicModels = _topicService.GetAllTopics(model.SearchStoreId)
                .Select(x =>x.ToModel())
                .ToList();
            //little hack here:
            //we don't have paging supported for topic list page
            //now ensure that topic bodies are not returned. otherwise, we can get the following error:
            //"Error during serialization or deserialization using the JSON JavaScriptSerializer. The length of the string exceeds the value set on the maxJsonLength property. "
            foreach (var topic in topicModels)
            {
                topic.Body = "";
            }
            var gridModel = new DataSourceResult
            {
                Data = topicModels,
                Total = topicModels.Count
            };

            return Json(gridModel);
        }

        #endregion

        #region Create / Edit / Delete

        public ActionResult Create()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            var model = new TopicModel();
            //templates
            PrepareTemplatesModel(model);
            //Stores
            PrepareStoresMappingModel(model, null, false);
            //locales
            AddLocales(_languageService, model.Locales);
            
            //default values
            model.DisplayOrder = 1;

            return View(model);
        }

        [HttpPost, ParameterBasedOnFormName("save-continue", "continueEditing")]
        public ActionResult Create(TopicModel model, bool continueEditing)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            if (ModelState.IsValid)
            {
                if (!model.IsPasswordProtected)
                {
                    model.Password = null;
                }

                var topic = model.ToEntity();
                _topicService.InsertTopic(topic);
                //search engine name
                model.SeName = topic.ValidateSeName(model.SeName, topic.Title ?? topic.SystemName, true);
                _urlRecordService.SaveSlug(topic, model.SeName, 0);
                //Stores
                SaveStoreMappings(topic, model);
                //locales
                UpdateLocales(topic, model);

                SuccessNotification(_localizationService.GetResource("Admin.ContentManagement.Topics.Added"));
                return continueEditing ? RedirectToAction("Edit", new { id = topic.Id }) : RedirectToAction("List");
            }

            //If we got this far, something failed, redisplay form

            //templates
            PrepareTemplatesModel(model);
            //Stores
            PrepareStoresMappingModel(model, null, true);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            var topic = _topicService.GetTopicById(id);
            if (topic == null)
                //No topic found with the specified id
                return RedirectToAction("List");

            var model = topic.ToModel();
            model.Url = Url.RouteUrl("Topic", new { SeName = topic.GetSeName() }, "http");
            //templates
            PrepareTemplatesModel(model);
            //Store
            PrepareStoresMappingModel(model, topic, false);
            //locales
            AddLocales(_languageService, model.Locales, (locale, languageId) =>
            {
                locale.Title = topic.GetLocalized(x => x.Title, languageId, false, false);
                locale.Body = topic.GetLocalized(x => x.Body, languageId, false, false);
                locale.MetaKeywords = topic.GetLocalized(x => x.MetaKeywords, languageId, false, false);
                locale.MetaDescription = topic.GetLocalized(x => x.MetaDescription, languageId, false, false);
                locale.MetaTitle = topic.GetLocalized(x => x.MetaTitle, languageId, false, false);
                locale.SeName = topic.GetSeName(languageId, false, false);
            });

            return View(model);
        }

        [HttpPost, ParameterBasedOnFormName("save-continue", "continueEditing")]
        public ActionResult Edit(TopicModel model, bool continueEditing)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            var topic = _topicService.GetTopicById(model.Id);
            if (topic == null)
                //No topic found with the specified id
                return RedirectToAction("List");

            if (!model.IsPasswordProtected)
            {
                model.Password = null;
            }

            if (ModelState.IsValid)
            {
                topic = model.ToEntity(topic);
                _topicService.UpdateTopic(topic);
                //search engine name
                model.SeName = topic.ValidateSeName(model.SeName, topic.Title ?? topic.SystemName, true);
                _urlRecordService.SaveSlug(topic, model.SeName, 0);
                //Stores
                SaveStoreMappings(topic, model);
                //locales
                UpdateLocales(topic, model);
                
                SuccessNotification(_localizationService.GetResource("Admin.ContentManagement.Topics.Updated"));
                
                if (continueEditing)
                {
                    //selected tab
                    SaveSelectedTabIndex();

                    return RedirectToAction("Edit",  new {id = topic.Id});
                }
                return RedirectToAction("List");
            }


            //If we got this far, something failed, redisplay form

            model.Url = Url.RouteUrl("Topic", new { SeName = topic.GetSeName() }, "http");
            //templates
            PrepareTemplatesModel(model);
            //Store
            PrepareStoresMappingModel(model, topic, true);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageTopics))
                return AccessDeniedView();

            var topic = _topicService.GetTopicById(id);
            if (topic == null)
                //No topic found with the specified id
                return RedirectToAction("List");

            _topicService.DeleteTopic(topic);

            SuccessNotification(_localizationService.GetResource("Admin.ContentManagement.Topics.Deleted"));
            return RedirectToAction("List");
        }
        
        #endregion
    }
}
