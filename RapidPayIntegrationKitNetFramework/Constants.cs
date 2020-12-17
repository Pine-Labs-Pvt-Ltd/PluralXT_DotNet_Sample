using System;
using System.Collections.Generic;
using System.Text;

namespace RapidPayIntegration
{
   public class Constants
    {
        public const string ORDER_CREATION_END_POINT = "api/v2/order/create";
        public const string DEV_DOMAIN_NAME= "http://localhost:51462/";
        public const string TEST_DOMAIN_NAME = "https://rapidpay.pinepg.in/";
        public const int SUCCESS = 1;
        public const int FAILURE = -1;

        public const string REDIRECT_URL_END_POINT = "pinepg/v2/process/payment/redirect?ordertoken=";
        public const string REDIRECT_URL_PAYMENT_MODES = "&paymentmodecsv=";
        public const string DO_REFUND_URL = "api/pg/payments/";
        public const string REFUND_ENDPOINT = "/refund";
        public const string DO_ORDER_INQUIRY_ENDPOINT = "api/pg/orders/";
        public const string PAYMENT_INQUIRY_ENDPOINT = "/payments";

        public static readonly string HASH_ALGO_SHA256 = "SHA256";
        public static readonly string HASH_ALGO_MD5 = "MD5";

        public static readonly string EMPTY = string.Empty;
        public static readonly string DIA_SECRET = "dia_secret";
        public static readonly string DIA_SECRET_TYPE = "dia_secret_type";


    }
}
