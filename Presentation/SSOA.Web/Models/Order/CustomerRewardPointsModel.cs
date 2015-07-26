using System;
using System.Collections.Generic;
using SSOA.Web.Framework;
using SSOA.Web.Framework.Mvc;

namespace SSOA.Web.Models.Order
{
    public partial class CustomerRewardPointsModel : BaseSSOAModel
    {
        public CustomerRewardPointsModel()
        {
            RewardPoints = new List<RewardPointsHistoryModel>();
        }

        public IList<RewardPointsHistoryModel> RewardPoints { get; set; }
        public int RewardPointsBalance { get; set; }
        public string RewardPointsAmount { get; set; }
        public int MinimumRewardPointsBalance { get; set; }
        public string MinimumRewardPointsAmount { get; set; }

        #region Nested classes

        public partial class RewardPointsHistoryModel : BaseSSOAEntityModel
        {
            [SSOAResourceDisplayName("RewardPoints.Fields.Points")]
            public int Points { get; set; }

            [SSOAResourceDisplayName("RewardPoints.Fields.PointsBalance")]
            public int PointsBalance { get; set; }

            [SSOAResourceDisplayName("RewardPoints.Fields.Message")]
            public string Message { get; set; }

            [SSOAResourceDisplayName("RewardPoints.Fields.Date")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}