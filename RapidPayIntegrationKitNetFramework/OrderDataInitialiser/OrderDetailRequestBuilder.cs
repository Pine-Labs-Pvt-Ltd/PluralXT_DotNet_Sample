using System;
using System.Collections.Generic;
using System.Text;
using RapidPayIntegration.DTO;
using RapidPayIntegration.Enums;

namespace RapidPayIntegration.OrderDataInitialiser
{
    public class OrderDetailRequestBuilder
    {
       

        private OrderDetailsRequest _OrderDetailsDto = null;
        public OrderDetailRequestBuilder(OrderDetailsRequest orderDetailsDto)
        {
            _OrderDetailsDto = orderDetailsDto;
        }

        public OrderDetailRequestBuilder InitialiseMerchantData()
        {            
            this._OrderDetailsDto.MerchantRequest = new MerchantRequest();
            return this;
        }

        public OrderDetailRequestBuilder SetMerchantId(int MerchantId)
        {
            this._OrderDetailsDto.MerchantRequest.MerchantId = MerchantId;
            return this;
        }

        public OrderDetailRequestBuilder SetMerchantAccessCode(string MerchantAccessCode)
        {
            this._OrderDetailsDto.MerchantRequest.MerchantAccessCode = MerchantAccessCode;
            return this;
        }

        public OrderDetailRequestBuilder SetMerchantURL(string MerchantReturnURL)
        {
            this._OrderDetailsDto.MerchantRequest.MerchantReturnUrl = MerchantReturnURL;
            return this;
        }

        public OrderDetailRequestBuilder SetMerchantOrderId(string OrderId)
        {
            this._OrderDetailsDto.MerchantRequest.MerchantOrderID = OrderId;
            return this;
        }

        public OrderDetailRequestBuilder InitialisePaymentInfoData()
        {
            this._OrderDetailsDto.OrderTxnInfoRequest = new OrderTxnInfoRequest();
            return this;
        }



        public OrderDetailRequestBuilder SetAmount(long Amount)
        {
            this._OrderDetailsDto.OrderTxnInfoRequest.Amount = Amount;
            return this;
        }

        public OrderDetailRequestBuilder SetCurrencyCode(EnumCurrency CurrencyCode)
        {
            this._OrderDetailsDto.OrderTxnInfoRequest.CurrencyCode = CurrencyCode;
            return this;
        }

        public OrderDetailRequestBuilder SetOrderDescription(string OrderDescription)
        {
            this._OrderDetailsDto.OrderTxnInfoRequest.OrderDesc = OrderDescription;
            return this;
        }


        public OrderDetailRequestBuilder InitialiseCustomerData()
        {
            this._OrderDetailsDto.CustomerRequest = new CustomerRequest();
            return this;
        }
              

        public OrderDetailRequestBuilder SetCustomerId(int CustomerId)
        {
            this._OrderDetailsDto.CustomerRequest.CustomerId = CustomerId;
            return this;
        }

        public OrderDetailRequestBuilder SetCustomerReferenceNumber(string CustomerReferenceNumber)
        {
            this._OrderDetailsDto.CustomerRequest.CustomerReferenceNumber = CustomerReferenceNumber;
            return this;
        }

        public OrderDetailRequestBuilder SetFirstName(string FirstName)
        {
            this._OrderDetailsDto.CustomerRequest.FirstName= FirstName;
            return this;
        }

        public OrderDetailRequestBuilder SetLastName(string LastName)
        {
            this._OrderDetailsDto.CustomerRequest.LastName = LastName;
            return this;
        }


        public OrderDetailRequestBuilder SetMobileNumber(string MobileNumber)
        {
            this._OrderDetailsDto.CustomerRequest.MobileNumber= MobileNumber;
            return this;
        }

        public OrderDetailRequestBuilder SetEmailId(string EmailId)
        {
            this._OrderDetailsDto.CustomerRequest.EmailId = EmailId;
            return this;
        }

        public OrderDetailRequestBuilder SetCountryCode(string CountryCode)
        {
            this._OrderDetailsDto.CustomerRequest.CountryCode = CountryCode;
            return this;
        }



        public OrderDetailRequestBuilder InitialiseBillingAddressData()
        {
            this._OrderDetailsDto.BillingAddressRequest = new BillingAddressRequest();
            return this;
        }


        public OrderDetailRequestBuilder SetBillingAddressFirstName(string FirstName)
        {
            this._OrderDetailsDto.BillingAddressRequest.FirstName = FirstName;
            return this;
        }

        public OrderDetailRequestBuilder SetBillingAddressLastName(string LastName)
        {
            this._OrderDetailsDto.BillingAddressRequest.LastName = LastName;
            return this;
        }



        public OrderDetailRequestBuilder SetBillingAddress1(string Address1)
        {
            this._OrderDetailsDto.BillingAddressRequest.Address1 = Address1;
            return this;
        }




        public OrderDetailRequestBuilder SetBillingAddress2(string Address2)
        {
            this._OrderDetailsDto.BillingAddressRequest.Address2 = Address2;
            return this;
        }



        public OrderDetailRequestBuilder SetBillingAddressCity(string City)
        {
            this._OrderDetailsDto.BillingAddressRequest.City = City;
            return this;
        }



        public OrderDetailRequestBuilder SetBillingAddressPinCode(string AddressPinCode)
        {
            this._OrderDetailsDto.BillingAddressRequest.AddressPinCode = AddressPinCode;
            return this;
        }



        public OrderDetailRequestBuilder SetBillingAddressState(string State)
        {
            this._OrderDetailsDto.BillingAddressRequest.State = State;
            return this;
        }


        public OrderDetailRequestBuilder SetBillingAddressCountry(string Country)
        {
            this._OrderDetailsDto.BillingAddressRequest.Country = Country;
            return this;
        }



        public OrderDetailRequestBuilder InitialiseShippingAddressData()
        {
            this._OrderDetailsDto.ShippingAddressRequest = new ShippingAddressRequest();
            return this;
        }


        public OrderDetailRequestBuilder SetShippingAddressFirstName(string FirstName)
        {
            this._OrderDetailsDto.ShippingAddressRequest.FirstName = FirstName;
            return this;
        }

        public OrderDetailRequestBuilder SetShippingAddressLastName(string LastName)
        {
            this._OrderDetailsDto.ShippingAddressRequest.LastName = LastName;
            return this;
        }



        public OrderDetailRequestBuilder SetShippingAddress1(string Address1)
        {
            this._OrderDetailsDto.ShippingAddressRequest.Address1 = Address1;
            return this;
        }




        public OrderDetailRequestBuilder SetShippingAddress2(string Address2)
        {
            this._OrderDetailsDto.ShippingAddressRequest.Address2 = Address2;
            return this;
        }



        public OrderDetailRequestBuilder SetShippingAddressCity(string City)
        {
            this._OrderDetailsDto.ShippingAddressRequest.City = City;
            return this;
        }



        public OrderDetailRequestBuilder SetShippingAddressPinCode(string AddressPinCode)
        {
            this._OrderDetailsDto.ShippingAddressRequest.AddressPinCode = AddressPinCode;
            return this;
        }



        public OrderDetailRequestBuilder SetShippingAddressState(string State)
        {
            this._OrderDetailsDto.ShippingAddressRequest.State = State;
            return this;
        }


        public OrderDetailRequestBuilder SetShippingAddressCountry(string Country)
        {
            this._OrderDetailsDto.ShippingAddressRequest.Country = Country;
            return this;
        }


        public OrderDetailRequestBuilder InitialiseAdditionalData()
        {
            this._OrderDetailsDto.AdditonalDataRequest = new AdditonalDataRequest();
            return this;
        }


        public OrderDetailRequestBuilder SetRfu1(string rfu1)
        {
            this._OrderDetailsDto.AdditonalDataRequest.RFU1 = rfu1;
            return this;
        }


        public OrderDetailRequestBuilder InitialiseProductData()
        {
            this._OrderDetailsDto.ProductInfoRequest = new ProductInfoRequest();
            return this;
        }


        public OrderDetailRequestBuilder SetProductDetails(string productCode, long productAmount)
        {
            ProductDetailsRequest prodDetails = new ProductDetailsRequest(productCode, productAmount);
            ProductDetailsRequest[] arrProductDetailsRequest = { prodDetails };
            this._OrderDetailsDto.ProductInfoRequest.productDetails = arrProductDetailsRequest;
            return this;
        }



    }
}
