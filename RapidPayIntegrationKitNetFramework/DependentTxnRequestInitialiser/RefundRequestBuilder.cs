using System;
using System.Collections.Generic;
using System.Text;
using RapidPayIntegration.DTO;

namespace RapidPayIntegration.DependentTxnRequestInitialiser
{
    public class RefundRequestBuilder
    {

        private PaymentRefundDataDto _PaymentRefundDataDto = null;
        public RefundRequestBuilder(PaymentRefundDataDto paymentRefundData)
        {
            _PaymentRefundDataDto = paymentRefundData;
        }

        public RefundRequestBuilder SetAmount(long Amount)
        {
            this._PaymentRefundDataDto.Amount = Amount;
            return this;
        }

        public RefundRequestBuilder SetUniqueMerchantTxnId(string  UniqueMerchantTxnId)
        {
            this._PaymentRefundDataDto.UniqueMerchantTxnId = UniqueMerchantTxnId;
            return this;
        }


        public RefundRequestBuilder SetMerchantId(int MerchantId)
        {
            this._PaymentRefundDataDto.MerchantId = MerchantId;
            return this;
        }


        public RefundRequestBuilder SetMerchantAcessCode(string  MerchantAccessCode)
        {
            this._PaymentRefundDataDto.MerchantAccessCode = MerchantAccessCode;
            return this;
        }

        public RefundRequestBuilder SetPaymentId(long PaymentId)
        {
            this._PaymentRefundDataDto.AggPaymentId = PaymentId;
            return this;
        }
    }
}
