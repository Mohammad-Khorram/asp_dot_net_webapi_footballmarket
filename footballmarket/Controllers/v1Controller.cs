using football_market.karafzar_tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace footballmarket.Controllers
{
    public class v1Controller : ApiController
    {
        [Route("/maintenance")]
        [HttpGet]
        public DataTable maintenance(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_maintenance";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/register")]
        [HttpGet]
        public DataTable register(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_register";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/getProfile")]
        [HttpGet]
        public DataTable getProfile(int userId, string type, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_getProfile";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@type", type);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/appUpdate")]
        [HttpGet]
        public DataTable appUpdate(int vc, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_appUpdate";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@vc", vc);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/slider")]
        [HttpGet]
        public DataTable slider(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_slider";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/sliderClick")]
        [HttpGet]
        public string sliderClick(int sliderId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_sliderClick";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@slider_id", sliderId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/card")]
        [HttpGet]
        public DataTable card(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_card";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/checkSubscriptionExist")]
        [HttpGet]
        public string checkSubscriptionExist(int userId, string bazaarProductId, string orderId, string signature, long bazaarDateTime, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_checkSubscriptionExist";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@bazaar_product_id", bazaarProductId);
            karafzar.sqlCommand.Parameters.AddWithValue("@order_id", orderId);
            karafzar.sqlCommand.Parameters.AddWithValue("@signature", signature);
            karafzar.sqlCommand.Parameters.AddWithValue("@bazaar_datetime", bazaarDateTime);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/subscriptionItems")]
        [HttpGet]
        public DataTable subscriptionItems(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_subscriptionItems";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/subscriptionAdd")]
        [HttpGet]
        public string subscriptionAdd(int userId, int subscriptionItemsId, string bazaarProductId, string orderId, string signature, long bazaarDateTime, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_subscriptionAdd";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@subscription_items_id", subscriptionItemsId);
            karafzar.sqlCommand.Parameters.AddWithValue("@bazaar_product_id", bazaarProductId);
            karafzar.sqlCommand.Parameters.AddWithValue("@order_id", orderId);
            karafzar.sqlCommand.Parameters.AddWithValue("@signature", signature);
            karafzar.sqlCommand.Parameters.AddWithValue("@bazaar_datetime", bazaarDateTime);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/country")]
        [HttpGet]
        public DataTable country(int continentId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_country";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@continent_id", continentId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/league")]
        [HttpGet]
        public DataTable league(int countryId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_league";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@country_id", countryId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/club")]
        [HttpGet]
        public DataTable club(int leagueId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_club";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@league_id", leagueId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/player")]
        [HttpGet]
        public DataTable player(int clubId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_player";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@club_id", clubId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/playerDetails")]
        [HttpGet]
        public DataTable playerDetails(int userId, int playerId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_playerDetails";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@player_id", playerId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/apifootballToken")]
        [HttpGet]
        public string apifootballToken(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_token_apifootball";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
            
        }

        [Route("/fifaRanking")]
        [HttpGet]
        public DataTable fifaRanking(int userId, int continentId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_fifaRanking";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@continent_id", continentId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/blog")]
        [HttpGet]
        public DataTable blog(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_blog";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/blogClick")]
        [HttpGet]
        public string blogClick(int blogId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_blogClick";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@blog_id", blogId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();
            return dataTable.Rows[0][0].ToString();
        }

        [Route("/blogComments")]
        [HttpGet]
        public DataTable blogComments(int blogId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_blogComments";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@blog_id", blogId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/blogCommentAdd")]
        [HttpGet]
        public string blogCommentAdd(int userId, int blogId, string content, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_blogCommentAdd";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@blog_id", blogId);
            karafzar.sqlCommand.Parameters.AddWithValue("@content", content);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/forbiddenWords")]
        [HttpGet]
        public DataTable forbiddenWords(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_forbiddenWords";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/notification")]
        [HttpGet]
        public DataTable notification(int userId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_notification";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/notificationSeen")]
        [HttpGet]
        public string notificationSeen(int userId, int notificationId, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_notificationSeen";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@notification_id", notificationId);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/profileEdit")]
        [HttpGet]
        public DataTable profileEdit(int userId, string fullName, string phone, string gender, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_profileEdit";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@fullname", fullName);
            karafzar.sqlCommand.Parameters.AddWithValue("@phone", phone);
            karafzar.sqlCommand.Parameters.AddWithValue("@gender", gender);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/feedback")]
        [HttpGet]
        public string feedback(int userId, string subject, string description, int vc, string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_feedback";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user_id", userId);
            karafzar.sqlCommand.Parameters.AddWithValue("@subject", subject);
            karafzar.sqlCommand.Parameters.AddWithValue("@description", description);
            karafzar.sqlCommand.Parameters.AddWithValue("@vc", vc);
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/terms")]
        [HttpGet]
        public string terms(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_terms";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/privacy")]
        [HttpGet]
        public string privacy(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_privacy";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }

        [Route("/contact")]
        [HttpGet]
        public DataTable contact(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return null;

            karafzar.sqlCommand.CommandText = "sp_v1_contact";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return null;

            return dataTable;
        }

        [Route("/about")]
        [HttpGet]
        public string about(string user, string pass)
        {
            if (!karafzar.checkToken(user, pass))
                return "false";

            karafzar.sqlCommand.CommandText = "sp_v1_about";
            karafzar.sqlCommand.CommandType = CommandType.StoredProcedure;
            karafzar.sqlCommand.Parameters.Clear();
            karafzar.sqlCommand.Parameters.AddWithValue("@user", user);
            karafzar.sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = karafzar.SqlDataAdapter();

            if (karafzar.hasError)
                return "false";

            return dataTable.Rows[0][0].ToString();
        }
    }
}
