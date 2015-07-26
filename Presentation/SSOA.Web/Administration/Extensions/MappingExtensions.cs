﻿using System;
using AutoMapper;
using SSOA.Admin.Models.Blogs;
using SSOA.Admin.Models.Catalog;
using SSOA.Admin.Models.Cms;
using SSOA.Admin.Models.Common;
using SSOA.Admin.Models.Customers;
using SSOA.Admin.Models.Directory;
using SSOA.Admin.Models.Discounts;
using SSOA.Admin.Models.ExternalAuthentication;
using SSOA.Admin.Models.Forums;
using SSOA.Admin.Models.Localization;
using SSOA.Admin.Models.Logging;
using SSOA.Admin.Models.Messages;
using SSOA.Admin.Models.News;
using SSOA.Admin.Models.Orders;
using SSOA.Admin.Models.Payments;
using SSOA.Admin.Models.Plugins;
using SSOA.Admin.Models.Polls;
using SSOA.Admin.Models.Settings;
using SSOA.Admin.Models.Shipping;
using SSOA.Admin.Models.Stores;
using SSOA.Admin.Models.Tax;
using SSOA.Admin.Models.Templates;
using SSOA.Admin.Models.Topics;
using SSOA.Admin.Models.Vendors;
using SSOA.Core.Domain.Blogs;
using SSOA.Core.Domain.Catalog;
using SSOA.Core.Domain.Common;
using SSOA.Core.Domain.Customers;
using SSOA.Core.Domain.Directory;

using SSOA.Core.Domain.Forums;
using SSOA.Core.Domain.Localization;
using SSOA.Core.Domain.Logging;
using SSOA.Core.Domain.Media;
using SSOA.Core.Domain.Messages;
using SSOA.Core.Domain.News;

using SSOA.Core.Domain.Polls;

using SSOA.Core.Domain.Stores;

using SSOA.Core.Domain.Topics;

using SSOA.Core.Plugins;
using SSOA.Services.Authentication.External;
using SSOA.Services.Cms;
using SSOA.Services.Common;

namespace SSOA.Admin.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination);
        }
        
        #region Category



        #endregion

        #region Manufacturer


        #endregion

        #region Vendor


        #endregion

        #region Products



        #endregion

        #region Product attributes

       

        #endregion

        #region Specification attributes

        #endregion

        #region Checkout attributes


        #endregion

        #region Customer attributes

        //attributes
        public static CustomerAttributeModel ToModel(this CustomerAttribute entity)
        {
            return entity.MapTo<CustomerAttribute, CustomerAttributeModel>();
        }

        public static CustomerAttribute ToEntity(this CustomerAttributeModel model)
        {
            return model.MapTo<CustomerAttributeModel, CustomerAttribute>();
        }

        public static CustomerAttribute ToEntity(this CustomerAttributeModel model, CustomerAttribute destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Address attributes

        //attributes
        public static AddressAttributeModel ToModel(this AddressAttribute entity)
        {
            return entity.MapTo<AddressAttribute, AddressAttributeModel>();
        }

        public static AddressAttribute ToEntity(this AddressAttributeModel model)
        {
            return model.MapTo<AddressAttributeModel, AddressAttribute>();
        }

        public static AddressAttribute ToEntity(this AddressAttributeModel model, AddressAttribute destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Languages

        public static LanguageModel ToModel(this Language entity)
        {
            return entity.MapTo<Language, LanguageModel>();
        }

        public static Language ToEntity(this LanguageModel model)
        {
            return model.MapTo<LanguageModel, Language>();
        }

        public static Language ToEntity(this LanguageModel model, Language destination)
        {
            return model.MapTo(destination);
        }
        
        #endregion

        #region Email account

        public static EmailAccountModel ToModel(this EmailAccount entity)
        {
            return entity.MapTo<EmailAccount, EmailAccountModel>();
        }

        public static EmailAccount ToEntity(this EmailAccountModel model)
        {
            return model.MapTo<EmailAccountModel, EmailAccount>();
        }

        public static EmailAccount ToEntity(this EmailAccountModel model, EmailAccount destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Message templates

        public static MessageTemplateModel ToModel(this MessageTemplate entity)
        {
            return entity.MapTo<MessageTemplate, MessageTemplateModel>();
        }

        public static MessageTemplate ToEntity(this MessageTemplateModel model)
        {
            return model.MapTo<MessageTemplateModel, MessageTemplate>();
        }

        public static MessageTemplate ToEntity(this MessageTemplateModel model, MessageTemplate destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Queued email

        public static QueuedEmailModel ToModel(this QueuedEmail entity)
        {
            return entity.MapTo<QueuedEmail, QueuedEmailModel>();
        }

        public static QueuedEmail ToEntity(this QueuedEmailModel model)
        {
            return model.MapTo<QueuedEmailModel, QueuedEmail>();
        }

        public static QueuedEmail ToEntity(this QueuedEmailModel model, QueuedEmail destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Campaigns

        public static CampaignModel ToModel(this Campaign entity)
        {
            return entity.MapTo<Campaign, CampaignModel>();
        }

        public static Campaign ToEntity(this CampaignModel model)
        {
            return model.MapTo<CampaignModel, Campaign>();
        }

        public static Campaign ToEntity(this CampaignModel model, Campaign destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Topics

        public static TopicModel ToModel(this Topic entity)
        {
            return entity.MapTo<Topic, TopicModel>();
        }

        public static Topic ToEntity(this TopicModel model)
        {
            return model.MapTo<TopicModel, Topic>();
        }

        public static Topic ToEntity(this TopicModel model, Topic destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Log

        public static LogModel ToModel(this Log entity)
        {
            return entity.MapTo<Log, LogModel>();
        }

        public static Log ToEntity(this LogModel model)
        {
            return model.MapTo<LogModel, Log>();
        }

        public static Log ToEntity(this LogModel model, Log destination)
        {
            return model.MapTo(destination);
        }

        public static ActivityLogTypeModel ToModel(this ActivityLogType entity)
        {
            return entity.MapTo<ActivityLogType, ActivityLogTypeModel>();
        }

        public static ActivityLogModel ToModel(this ActivityLog entity)
        {
            return entity.MapTo<ActivityLog, ActivityLogModel>();
        }

        #endregion
        
        #region Currencies

        public static CurrencyModel ToModel(this Currency entity)
        {
            return entity.MapTo<Currency, CurrencyModel>();
        }

        public static Currency ToEntity(this CurrencyModel model)
        {
            return model.MapTo<CurrencyModel, Currency>();
        }

        public static Currency ToEntity(this CurrencyModel model, Currency destination)
        {
            return model.MapTo(destination);
        }
        #endregion

        #region Measure weights

        public static MeasureWeightModel ToModel(this MeasureWeight entity)
        {
            return entity.MapTo<MeasureWeight, MeasureWeightModel>();
        }

        public static MeasureWeight ToEntity(this MeasureWeightModel model)
        {
            return model.MapTo<MeasureWeightModel, MeasureWeight>();
        }

        public static MeasureWeight ToEntity(this MeasureWeightModel model, MeasureWeight destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Measure dimension

        public static MeasureDimensionModel ToModel(this MeasureDimension entity)
        {
            return entity.MapTo<MeasureDimension, MeasureDimensionModel>();
        }

        public static MeasureDimension ToEntity(this MeasureDimensionModel model)
        {
            return model.MapTo<MeasureDimensionModel, MeasureDimension>();
        }

        public static MeasureDimension ToEntity(this MeasureDimensionModel model, MeasureDimension destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Tax providers


        #endregion

        #region Tax categories


        #endregion
        
        #region Shipping rate computation method



        #endregion

        #region Shipping methods


        #endregion

        #region Delivery dates

        

        #endregion
        
        #region Payment methods



        #endregion

        #region External authentication methods

        public static AuthenticationMethodModel ToModel(this IExternalAuthenticationMethod entity)
        {
            return entity.MapTo<IExternalAuthenticationMethod, AuthenticationMethodModel>();
        }

        #endregion
        
        #region Widgets

        public static WidgetModel ToModel(this IWidgetPlugin entity)
        {
            return entity.MapTo<IWidgetPlugin, WidgetModel>();
        }

        #endregion

        #region Address

        public static AddressModel ToModel(this Address entity)
        {
            return entity.MapTo<Address, AddressModel>();
        }

        public static Address ToEntity(this AddressModel model)
        {
            return model.MapTo<AddressModel, Address>();
        }

        public static Address ToEntity(this AddressModel model, Address destination)
        {
            return model.MapTo(destination);
        }

        public static void PrepareCustomAddressAttributes(this AddressModel model,
            Address address,
            IAddressAttributeService addressAttributeService,
            IAddressAttributeParser addressAttributeParser)
        {
            //this method is very similar to the same one in SSOA.Web project
            if (addressAttributeService == null)
                throw new ArgumentNullException("addressAttributeService");

            if (addressAttributeParser == null)
                throw new ArgumentNullException("addressAttributeParser");

            var attributes = addressAttributeService.GetAllAddressAttributes();
            foreach (var attribute in attributes)
            {
                var attributeModel = new AddressModel.AddressAttributeModel
                {
                    Id = attribute.Id,
                    Name = attribute.Name,
                    IsRequired = attribute.IsRequired,
                    AttributeControlType = attribute.AttributeControlType,
                };

                if (attribute.ShouldHaveValues())
                {
                    //values
                    var attributeValues = addressAttributeService.GetAddressAttributeValues(attribute.Id);
                    foreach (var attributeValue in attributeValues)
                    {
                        var attributeValueModel = new AddressModel.AddressAttributeValueModel
                        {
                            Id = attributeValue.Id,
                            Name = attributeValue.Name,
                            IsPreSelected = attributeValue.IsPreSelected
                        };
                        attributeModel.Values.Add(attributeValueModel);
                    }
                }

                //set already selected attributes
                var selectedAddressAttributes = address != null ? address.CustomAttributes : null;
                switch (attribute.AttributeControlType)
                {
                    case AttributeControlType.DropdownList:
                    case AttributeControlType.RadioList:
                    case AttributeControlType.Checkboxes:
                        {
                            if (!String.IsNullOrEmpty(selectedAddressAttributes))
                            {
                                //clear default selection
                                foreach (var item in attributeModel.Values)
                                    item.IsPreSelected = false;

                                //select new values
                                var selectedValues = addressAttributeParser.ParseAddressAttributeValues(selectedAddressAttributes);
                                foreach (var attributeValue in selectedValues)
                                    foreach (var item in attributeModel.Values)
                                        if (attributeValue.Id == item.Id)
                                            item.IsPreSelected = true;
                            }
                        }
                        break;
                    case AttributeControlType.ReadonlyCheckboxes:
                        {
                            //do nothing
                            //values are already pre-set
                        }
                        break;
                    case AttributeControlType.TextBox:
                    case AttributeControlType.MultilineTextbox:
                        {
                            if (!String.IsNullOrEmpty(selectedAddressAttributes))
                            {
                                var enteredText = addressAttributeParser.ParseValues(selectedAddressAttributes, attribute.Id);
                                if (enteredText.Count > 0)
                                    attributeModel.DefaultValue = enteredText[0];
                            }
                        }
                        break;
                    case AttributeControlType.ColorSquares:
                    case AttributeControlType.Datepicker:
                    case AttributeControlType.FileUpload:
                    default:
                        //not supported attribute control types
                        break;
                }

                model.CustomAddressAttributes.Add(attributeModel);
            }
        }

        #endregion

        #region NewsLetter subscriptions

        public static NewsLetterSubscriptionModel ToModel(this NewsLetterSubscription entity)
        {
            return entity.MapTo<NewsLetterSubscription, NewsLetterSubscriptionModel>();
        }

        public static NewsLetterSubscription ToEntity(this NewsLetterSubscriptionModel model)
        {
            return model.MapTo<NewsLetterSubscriptionModel, NewsLetterSubscription>();
        }

        public static NewsLetterSubscription ToEntity(this NewsLetterSubscriptionModel model, NewsLetterSubscription destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Discounts


        #endregion

        #region Forums

        //forum groups
        public static ForumGroupModel ToModel(this ForumGroup entity)
        {
            return entity.MapTo<ForumGroup, ForumGroupModel>();
        }

        public static ForumGroup ToEntity(this ForumGroupModel model)
        {
            return model.MapTo<ForumGroupModel, ForumGroup>();
        }

        public static ForumGroup ToEntity(this ForumGroupModel model, ForumGroup destination)
        {
            return model.MapTo(destination);
        }
        //forums
        public static ForumModel ToModel(this Forum entity)
        {
            return entity.MapTo<Forum, ForumModel>();
        }

        public static Forum ToEntity(this ForumModel model)
        {
            return model.MapTo<ForumModel, Forum>();
        }

        public static Forum ToEntity(this ForumModel model, Forum destination)
        {
            return model.MapTo(destination);
        }
        #endregion

        #region Blog

        //blog posts
        public static BlogPostModel ToModel(this BlogPost entity)
        {
            return entity.MapTo<BlogPost, BlogPostModel>();
        }

        public static BlogPost ToEntity(this BlogPostModel model)
        {
            return model.MapTo<BlogPostModel, BlogPost>();
        }

        public static BlogPost ToEntity(this BlogPostModel model, BlogPost destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region News

        //news items
        public static NewsItemModel ToModel(this NewsItem entity)
        {
            return entity.MapTo<NewsItem, NewsItemModel>();
        }

        public static NewsItem ToEntity(this NewsItemModel model)
        {
            return model.MapTo<NewsItemModel, NewsItem>();
        }

        public static NewsItem ToEntity(this NewsItemModel model, NewsItem destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Polls

        //news items
        public static PollModel ToModel(this Poll entity)
        {
            return entity.MapTo<Poll, PollModel>();
        }

        public static Poll ToEntity(this PollModel model)
        {
            return model.MapTo<PollModel, Poll>();
        }

        public static Poll ToEntity(this PollModel model, Poll destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Customer roles

        //customer roles
        public static CustomerRoleModel ToModel(this CustomerRole entity)
        {
            return entity.MapTo<CustomerRole, CustomerRoleModel>();
        }

        public static CustomerRole ToEntity(this CustomerRoleModel model)
        {
            return model.MapTo<CustomerRoleModel, CustomerRole>();
        }

        public static CustomerRole ToEntity(this CustomerRoleModel model, CustomerRole destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Gift Cards


        #endregion

        #region Countries / states

        public static CountryModel ToModel(this Country entity)
        {
            return entity.MapTo<Country, CountryModel>();
        }

        public static Country ToEntity(this CountryModel model)
        {
            return model.MapTo<CountryModel, Country>();
        }

        public static Country ToEntity(this CountryModel model, Country destination)
        {
            return model.MapTo(destination);
        }

        public static StateProvinceModel ToModel(this StateProvince entity)
        {
            return entity.MapTo<StateProvince, StateProvinceModel>();
        }

        public static StateProvince ToEntity(this StateProvinceModel model)
        {
            return model.MapTo<StateProvinceModel, StateProvince>();
        }

        public static StateProvince ToEntity(this StateProvinceModel model, StateProvince destination)
        {
            return model.MapTo(destination);
        }


        #endregion

        #region Settings





        public static ForumSettingsModel ToModel(this ForumSettings entity)
        {
            return entity.MapTo<ForumSettings, ForumSettingsModel>();
        }
        public static ForumSettings ToEntity(this ForumSettingsModel model, ForumSettings destination)
        {
            return model.MapTo(destination);
        }


        public static BlogSettingsModel ToModel(this BlogSettings entity)
        {
            return entity.MapTo<BlogSettings, BlogSettingsModel>();
        }
        public static BlogSettings ToEntity(this BlogSettingsModel model, BlogSettings destination)
        {
            return model.MapTo(destination);
        }


        public static NewsSettingsModel ToModel(this NewsSettings entity)
        {
            return entity.MapTo<NewsSettings, NewsSettingsModel>();
        }
        public static NewsSettings ToEntity(this NewsSettingsModel model, NewsSettings destination)
        {
            return model.MapTo(destination);
        }

        public static RewardPointsSettingsModel ToModel(this RewardPointsSettings entity)
        {
            return entity.MapTo<RewardPointsSettings, RewardPointsSettingsModel>();
        }
        public static RewardPointsSettings ToEntity(this RewardPointsSettingsModel model, RewardPointsSettings destination)
        {
            return model.MapTo(destination);
        }


        public static MediaSettingsModel ToModel(this MediaSettings entity)
        {
            return entity.MapTo<MediaSettings, MediaSettingsModel>();
        }
        public static MediaSettings ToEntity(this MediaSettingsModel model, MediaSettings destination)
        {
            return model.MapTo(destination);
        }

        //customer/user settings
        public static CustomerUserSettingsModel.CustomerSettingsModel ToModel(this CustomerSettings entity)
        {
            return entity.MapTo<CustomerSettings, CustomerUserSettingsModel.CustomerSettingsModel>();
        }
        public static CustomerSettings ToEntity(this CustomerUserSettingsModel.CustomerSettingsModel model, CustomerSettings destination)
        {
            return model.MapTo(destination);
        }
        public static CustomerUserSettingsModel.AddressSettingsModel ToModel(this AddressSettings entity)
        {
            return entity.MapTo<AddressSettings, CustomerUserSettingsModel.AddressSettingsModel>();
        }
        public static AddressSettings ToEntity(this CustomerUserSettingsModel.AddressSettingsModel model, AddressSettings destination)
        {
            return model.MapTo(destination);
        }
        #endregion

        #region Plugins

        public static PluginModel ToModel(this PluginDescriptor entity)
        {
            return entity.MapTo<PluginDescriptor, PluginModel>();
        }

        #endregion

        #region Stores

        public static StoreModel ToModel(this Store entity)
        {
            return entity.MapTo<Store, StoreModel>();
        }

        public static Store ToEntity(this StoreModel model)
        {
            return model.MapTo<StoreModel, Store>();
        }

        public static Store ToEntity(this StoreModel model, Store destination)
        {
            return model.MapTo(destination);
        }

        #endregion

        #region Templates

       




        public static TopicTemplateModel ToModel(this TopicTemplate entity)
        {
            return entity.MapTo<TopicTemplate, TopicTemplateModel>();
        }

        public static TopicTemplate ToEntity(this TopicTemplateModel model)
        {
            return model.MapTo<TopicTemplateModel, TopicTemplate>();
        }

        public static TopicTemplate ToEntity(this TopicTemplateModel model, TopicTemplate destination)
        {
            return model.MapTo(destination);
        }

        #endregion

    }
}