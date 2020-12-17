using Newtonsoft.Json;


namespace RapidPayIntegration.HttpResponses
{
    public class PaymentDetailsResponseSentToMerchant : Response
    {
      

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string unique_merchant_txn_id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pine_pg_txn_status { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string txn_completion_date_time { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string txn_response_code { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string txn_response_msg { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string acquirer_name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string pine_pg_transaction_id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dia_secret { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string dia_secret_type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string merchant_return_url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_tenure_month { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_interest_rate_percent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_processing_fee { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_principal_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_amount_payable_each_month_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string product_code { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string product_display_name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string is_bank_emi_txn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string is_brand_emi_txn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string captured_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string refund_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_cashback_type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_issuer_discount_cashabck_perecent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_issuer_discount_cashback_fixed_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_merchant_discount_cashabck_perecent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_merchant_discount_cashback_fixed_amount_in_paisa { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_total_discount_cashback_percent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_total_discount_cashback_fixed_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_total_discount_cashabck_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_additional_cashback { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string emi_additional_reward_pints { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string payment_mode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string addon_instant_discount_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string original_txn_amount_in_paisa { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string addon_instant_discount_percent { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string addon_reward_point_multiplier { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string addon_reward_points_awarded { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string parent_txn_status { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string parent_txn_response_code { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string parent_txn_response_message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string program_type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string masked_card_number { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string rwd_customer_mobile_no { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string lr_merchant_id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string stan { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string lr_program_name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string lr_auth_code { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string lr_approved_redeem_points { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string is_eze_click { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string issuer_name { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string product_category { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string product_description { get; set; }



        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string manufacturer { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string mobile_no { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string udf_field_1 { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string udf_field_2 { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string udf_field_3 { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string udf_field_4 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string card_holder_name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string salted_card_hash { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string invoice_number { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string rrn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string auth_code { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string product_discount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string txn_additional_info { get; set; }



    }
}