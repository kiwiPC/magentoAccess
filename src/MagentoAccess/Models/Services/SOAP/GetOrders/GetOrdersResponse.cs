﻿using System.Collections.Generic;
using System.Linq;
using MagentoAccess.MagentoSoapServiceReference;

namespace MagentoAccess.Models.Services.Soap.GetOrders
{
	internal class GetOrdersResponse
	{
		public GetOrdersResponse( salesOrderListResponse res )
		{
			var orders = res.result.Select( x => new Order( x ) );
			Orders = orders;
		}

		public GetOrdersResponse( MagentoSoapServiceReference_v_1_14_1_EE.salesOrderListResponse res )
		{
			var orders = res.result.Select( x => new Order( x ) );
			Orders = orders;
		}

		public IEnumerable< Order > Orders { get; set; }
	}

	internal class Order
	{
		public Order( salesOrderListEntity salesOrderListEntity )
		{
			this.AdjustmentNegative = salesOrderListEntity.adjustment_negative;
			this.AdjustmentPositive = salesOrderListEntity.adjustment_positive;
			this.AppliedRuleIds = salesOrderListEntity.applied_rule_ids;
			this.BaseAdjustmentNegative = salesOrderListEntity.base_adjustment_negative;
			this.BaseAdjustmentPositive = salesOrderListEntity.base_adjustment_positive;
			this.BaseCurrencyCode = salesOrderListEntity.base_currency_code;
			this.BaseCustomerBalanceAmount = salesOrderListEntity.base_customer_balance_amount;
			this.BaseCustomerBalanceInvoiced = salesOrderListEntity.base_customer_balance_invoiced;
			this.BaseCustomerBalanceRefunded = salesOrderListEntity.base_customer_balance_refunded;
			this.BaseCustomerBalanceTotalRefunded = salesOrderListEntity.base_customer_balance_total_refunded;
			this.BaseDiscountAmount = salesOrderListEntity.base_discount_amount;
			this.BaseDiscountCanceled = salesOrderListEntity.base_discount_canceled;
			this.BaseDiscountInvoiced = salesOrderListEntity.base_discount_invoiced;
			this.BaseDiscountRefunded = salesOrderListEntity.base_discount_refunded;
			this.BaseGiftCardsAmount = salesOrderListEntity.base_gift_cards_amount;
			this.BaseGiftCardsInvoiced = salesOrderListEntity.base_gift_cards_invoiced;
			this.BaseGiftCardsRefunded = salesOrderListEntity.base_gift_cards_refunded;
			this.BaseGrandTotal = salesOrderListEntity.base_grand_total;
			this.BaseHiddenTaxAmount = salesOrderListEntity.base_hidden_tax_amount;
			this.BaseHiddenTaxInvoiced = salesOrderListEntity.base_hidden_tax_invoiced;
			this.BaseHiddenTaxRefunded = salesOrderListEntity.base_hidden_tax_refunded;
			this.BaseRewardCurrencyAmount = salesOrderListEntity.base_reward_currency_amount;
			this.BaseRewardCurrencyAmountInvoiced = salesOrderListEntity.base_reward_currency_amount_invoiced;
			this.BaseRewardCurrencyAmountRefunded = salesOrderListEntity.base_reward_currency_amount_refunded;
			this.BaseShippingAmount = salesOrderListEntity.base_shipping_amount;
			this.BaseShippingCanceled = salesOrderListEntity.base_shipping_canceled;
			this.BaseShippingDiscountAmount = salesOrderListEntity.base_shipping_discount_amount;
			this.BaseShippingHiddenTaxAmount = salesOrderListEntity.base_shipping_hidden_tax_amount;
			this.BaseShippingInclTax = salesOrderListEntity.base_shipping_incl_tax;
			this.BaseShippingInvoiced = salesOrderListEntity.base_shipping_invoiced;
			this.BaseShippingRefunded = salesOrderListEntity.base_shipping_refunded;
			this.BaseShippingTaxAmount = salesOrderListEntity.base_shipping_tax_amount;
			this.BaseShippingTaxRefunded = salesOrderListEntity.base_shipping_tax_refunded;
			this.BaseSubtotal = salesOrderListEntity.base_subtotal;
			this.BaseSubtotalCanceled = salesOrderListEntity.base_subtotal_canceled;
			this.BaseSubtotalInclTax = salesOrderListEntity.base_subtotal_incl_tax;
			this.BaseSubtotalInvoiced = salesOrderListEntity.base_subtotal_invoiced;
			this.BaseSubtotalRefunded = salesOrderListEntity.base_subtotal_refunded;
			this.BaseTaxAmount = salesOrderListEntity.base_tax_amount;
			this.BaseTaxCanceled = salesOrderListEntity.base_tax_canceled;
			this.BaseTaxInvoiced = salesOrderListEntity.base_tax_invoiced;
			this.BaseTaxRefunded = salesOrderListEntity.base_tax_refunded;
			this.BaseToGlobalRate = salesOrderListEntity.base_to_global_rate;
			this.BaseToOrderRate = salesOrderListEntity.base_to_order_rate;
			this.BaseTotalCanceled = salesOrderListEntity.base_total_canceled;
			this.BaseTotalDue = salesOrderListEntity.base_total_due;
			this.BaseTotalInvoiced = salesOrderListEntity.base_total_invoiced;
			this.BaseTotalInvoicedCost = salesOrderListEntity.base_total_invoiced_cost;
			this.BaseTotalOfflineRefunded = salesOrderListEntity.base_total_offline_refunded;
			this.BaseTotalOnlineRefunded = salesOrderListEntity.base_total_online_refunded;
			this.BaseTotalPaid = salesOrderListEntity.base_total_paid;
			this.BaseTotalQtyOrdered = salesOrderListEntity.base_total_qty_ordered;
			this.BaseTotalRefunded = salesOrderListEntity.base_total_refunded;
			this.BillingAddressId = salesOrderListEntity.billing_address_id;
			this.BillingFirstname = salesOrderListEntity.billing_firstname;
			this.BillingLastname = salesOrderListEntity.billing_lastname;
			this.BillingName = salesOrderListEntity.billing_name;
			this.CanShipPartially = salesOrderListEntity.can_ship_partially;
			this.CanShipPartiallyItem = salesOrderListEntity.can_ship_partially_item;
			this.CouponCode = salesOrderListEntity.coupon_code;
			this.CreatedAt = salesOrderListEntity.created_at;
			this.CustomerBalanceAmount = salesOrderListEntity.customer_balance_amount;
			this.CustomerBalanceInvoiced = salesOrderListEntity.customer_balance_invoiced;
			this.CustomerBalanceRefunded = salesOrderListEntity.customer_balance_refunded;
			this.CustomerBalanceTotalRefunded = salesOrderListEntity.customer_balance_total_refunded;
			this.CustomerDob = salesOrderListEntity.customer_dob;
			this.CustomerEmail = salesOrderListEntity.customer_email;
			this.CustomerFirstname = salesOrderListEntity.customer_firstname;
			this.CustomerGender = salesOrderListEntity.customer_gender;
			this.CustomerGroupId = salesOrderListEntity.customer_group_id;
			this.CustomerId = salesOrderListEntity.customer_id;
			this.CustomerIsGuest = salesOrderListEntity.customer_is_guest;
			this.CustomerLastname = salesOrderListEntity.customer_lastname;
			this.CustomerMiddlename = salesOrderListEntity.customer_middlename;
			this.CustomerNote = salesOrderListEntity.customer_note;
			this.CustomerNoteNotify = salesOrderListEntity.customer_note_notify;
			this.CustomerPrefix = salesOrderListEntity.customer_prefix;
			this.CustomerSuffix = salesOrderListEntity.customer_suffix;
			this.CustomerTaxvat = salesOrderListEntity.customer_taxvat;
			this.DiscountAmount = salesOrderListEntity.discount_amount;
			this.DiscountCanceled = salesOrderListEntity.discount_canceled;
			this.DiscountDescription = salesOrderListEntity.discount_description;
			this.DiscountInvoiced = salesOrderListEntity.discount_invoiced;
			this.DiscountRefunded = salesOrderListEntity.discount_refunded;
			this.EditIncrement = salesOrderListEntity.edit_increment;
			this.EmailSent = salesOrderListEntity.email_sent;
			this.ExtCustomerId = salesOrderListEntity.ext_customer_id;
			this.ExtOrderId = salesOrderListEntity.ext_order_id;
			this.Firstname = salesOrderListEntity.firstname;
			this.ForcedDoShipmentWithInvoice = salesOrderListEntity.forced_do_shipment_with_invoice;
			this.GiftCards = salesOrderListEntity.gift_cards;
			this.GiftCardsAmount = salesOrderListEntity.gift_cards_amount;
			this.GiftCardsInvoiced = salesOrderListEntity.gift_cards_invoiced;
			this.GiftCardsRefunded = salesOrderListEntity.gift_cards_refunded;
			this.GiftMessageId = salesOrderListEntity.gift_message_id;
			this.GlobalCurrencyCode = salesOrderListEntity.global_currency_code;
			this.GrandTotal = salesOrderListEntity.grand_total;
			this.HiddenTaxAmount = salesOrderListEntity.hidden_tax_amount;
			this.HiddenTaxInvoiced = salesOrderListEntity.hidden_tax_invoiced;
			this.HiddenTaxRefunded = salesOrderListEntity.hidden_tax_refunded;
			this.HoldBeforeState = salesOrderListEntity.hold_before_state;
			this.HoldBeforeStatus = salesOrderListEntity.hold_before_status;
			this.incrementId = salesOrderListEntity.increment_id;
			this.IsVirtual = salesOrderListEntity.is_virtual;
			this.Lastname = salesOrderListEntity.lastname;
			this.OrderCurrencyCode = salesOrderListEntity.order_currency_code;
			this.OrderId = salesOrderListEntity.order_id;
			this.OriginalIncrementId = salesOrderListEntity.original_increment_id;
			this.PaymentAuthorizationAmount = salesOrderListEntity.payment_authorization_amount;
			this.PaymentAuthorizationExpiration = salesOrderListEntity.payment_authorization_expiration;
			this.PaypalIpnCustomerNotified = salesOrderListEntity.paypal_ipn_customer_notified;
			this.Postcode = salesOrderListEntity.postcode;
			this.ProtectCode = salesOrderListEntity.protect_code;
			this.QuoteAddressId = salesOrderListEntity.quote_address_id;
			this.QuoteId = salesOrderListEntity.quote_id;
			this.RelationChildId = salesOrderListEntity.relation_child_id;
			this.RelationChildRealId = salesOrderListEntity.relation_child_real_id;
			this.RelationParentId = salesOrderListEntity.relation_parent_id;
			this.RelationParentRealId = salesOrderListEntity.relation_parent_real_id;
			this.RemoteIp = salesOrderListEntity.remote_ip;
			this.RewardCurrencyAmount = salesOrderListEntity.reward_currency_amount;
			this.RewardCurrencyAmountInvoiced = salesOrderListEntity.reward_currency_amount_invoiced;
			this.RewardCurrencyAmountRefunded = salesOrderListEntity.reward_currency_amount_refunded;
			this.RewardPointsBalance = salesOrderListEntity.reward_points_balance;
			this.RewardPointsBalanceRefunded = salesOrderListEntity.reward_points_balance_refunded;
			this.RewardPointsBalanceToRefund = salesOrderListEntity.reward_points_balance_to_refund;
			this.RewardSalesrulePoints = salesOrderListEntity.reward_salesrule_points;
			this.ShippingAddressId = salesOrderListEntity.shipping_address_id;
			this.ShippingAmount = salesOrderListEntity.shipping_amount;
			this.ShippingCanceled = salesOrderListEntity.shipping_canceled;
			this.ShippingDescription = salesOrderListEntity.shipping_description;
			this.ShippingDiscountAmount = salesOrderListEntity.shipping_discount_amount;
			this.ShippingFirstname = salesOrderListEntity.shipping_firstname;
			this.ShippingHiddenTaxAmount = salesOrderListEntity.shipping_hidden_tax_amount;
			this.ShippingInclTax = salesOrderListEntity.shipping_incl_tax;
			this.ShippingInvoiced = salesOrderListEntity.shipping_invoiced;
			this.ShippingLastname = salesOrderListEntity.shipping_lastname;
			this.ShippingMethod = salesOrderListEntity.shipping_method;
			this.ShippingName = salesOrderListEntity.shipping_name;
			this.ShippingRefunded = salesOrderListEntity.shipping_refunded;
			this.ShippingTaxAmount = salesOrderListEntity.shipping_tax_amount;
			this.ShippingTaxRefunded = salesOrderListEntity.shipping_tax_refunded;
			this.State = salesOrderListEntity.state;
			this.Status = salesOrderListEntity.status;
			this.StoreCurrencyCode = salesOrderListEntity.store_currency_code;
			this.StoreId = salesOrderListEntity.store_id;
			this.StoreName = salesOrderListEntity.store_name;
			this.StoreToBaseRate = salesOrderListEntity.store_to_base_rate;
			this.StoreToOrderRate = salesOrderListEntity.store_to_order_rate;
			this.Subtotal = salesOrderListEntity.subtotal;
			this.SubtotalCanceled = salesOrderListEntity.subtotal_canceled;
			this.SubtotalInclTax = salesOrderListEntity.subtotal_incl_tax;
			this.SubtotalInvoiced = salesOrderListEntity.subtotal_invoiced;
			this.SubtotalRefunded = salesOrderListEntity.subtotal_refunded;
			this.TaxAmount = salesOrderListEntity.tax_amount;
			this.TaxCanceled = salesOrderListEntity.tax_canceled;
			this.TaxInvoiced = salesOrderListEntity.tax_invoiced;
			this.TaxRefunded = salesOrderListEntity.tax_refunded;
			this.Telephone = salesOrderListEntity.telephone;
			this.TotalCanceled = salesOrderListEntity.total_canceled;
			this.TotalDue = salesOrderListEntity.total_due;
			this.TotalInvoiced = salesOrderListEntity.total_invoiced;
			this.TotalItemCount = salesOrderListEntity.total_item_count;
			this.TotalOfflineRefunded = salesOrderListEntity.total_offline_refunded;
			this.TotalOnlineRefunded = salesOrderListEntity.total_online_refunded;
			this.TotalPaid = salesOrderListEntity.total_paid;
			this.TotalQtyOrdered = salesOrderListEntity.total_qty_ordered;
			this.TotalRefunded = salesOrderListEntity.total_refunded;
			this.UpdatedAt = salesOrderListEntity.updated_at;
			this.Weight = salesOrderListEntity.weight;
			this.XForwardedFOR = salesOrderListEntity.x_forwarded_for;
		}

		public Order( MagentoSoapServiceReference_v_1_14_1_EE.salesOrderListEntity salesOrderListEntity )
		{
			this.AdjustmentNegative = salesOrderListEntity.adjustment_negative;
			this.AdjustmentPositive = salesOrderListEntity.adjustment_positive;
			this.AppliedRuleIds = salesOrderListEntity.applied_rule_ids;
			this.BaseAdjustmentNegative = salesOrderListEntity.base_adjustment_negative;
			this.BaseAdjustmentPositive = salesOrderListEntity.base_adjustment_positive;
			this.BaseCurrencyCode = salesOrderListEntity.base_currency_code;
			this.BaseCustomerBalanceAmount = salesOrderListEntity.base_customer_balance_amount;
			this.BaseCustomerBalanceInvoiced = salesOrderListEntity.base_customer_balance_invoiced;
			this.BaseCustomerBalanceRefunded = salesOrderListEntity.base_customer_balance_refunded;
			this.BaseCustomerBalanceTotalRefunded = salesOrderListEntity.base_customer_balance_total_refunded;
			this.BaseDiscountAmount = salesOrderListEntity.base_discount_amount;
			this.BaseDiscountCanceled = salesOrderListEntity.base_discount_canceled;
			this.BaseDiscountInvoiced = salesOrderListEntity.base_discount_invoiced;
			this.BaseDiscountRefunded = salesOrderListEntity.base_discount_refunded;
			this.BaseGiftCardsAmount = salesOrderListEntity.base_gift_cards_amount;
			this.BaseGiftCardsInvoiced = salesOrderListEntity.base_gift_cards_invoiced;
			this.BaseGiftCardsRefunded = salesOrderListEntity.base_gift_cards_refunded;
			this.BaseGrandTotal = salesOrderListEntity.base_grand_total;
			this.BaseHiddenTaxAmount = salesOrderListEntity.base_hidden_tax_amount;
			this.BaseHiddenTaxInvoiced = salesOrderListEntity.base_hidden_tax_invoiced;
			this.BaseHiddenTaxRefunded = salesOrderListEntity.base_hidden_tax_refunded;
			this.BaseRewardCurrencyAmount = salesOrderListEntity.base_reward_currency_amount;
			this.BaseRewardCurrencyAmountInvoiced = salesOrderListEntity.base_reward_currency_amount_invoiced;
			this.BaseRewardCurrencyAmountRefunded = salesOrderListEntity.base_reward_currency_amount_refunded;
			this.BaseShippingAmount = salesOrderListEntity.base_shipping_amount;
			this.BaseShippingCanceled = salesOrderListEntity.base_shipping_canceled;
			this.BaseShippingDiscountAmount = salesOrderListEntity.base_shipping_discount_amount;
			this.BaseShippingHiddenTaxAmount = salesOrderListEntity.base_shipping_hidden_tax_amount;
			this.BaseShippingInclTax = salesOrderListEntity.base_shipping_incl_tax;
			this.BaseShippingInvoiced = salesOrderListEntity.base_shipping_invoiced;
			this.BaseShippingRefunded = salesOrderListEntity.base_shipping_refunded;
			this.BaseShippingTaxAmount = salesOrderListEntity.base_shipping_tax_amount;
			this.BaseShippingTaxRefunded = salesOrderListEntity.base_shipping_tax_refunded;
			this.BaseSubtotal = salesOrderListEntity.base_subtotal;
			this.BaseSubtotalCanceled = salesOrderListEntity.base_subtotal_canceled;
			this.BaseSubtotalInclTax = salesOrderListEntity.base_subtotal_incl_tax;
			this.BaseSubtotalInvoiced = salesOrderListEntity.base_subtotal_invoiced;
			this.BaseSubtotalRefunded = salesOrderListEntity.base_subtotal_refunded;
			this.BaseTaxAmount = salesOrderListEntity.base_tax_amount;
			this.BaseTaxCanceled = salesOrderListEntity.base_tax_canceled;
			this.BaseTaxInvoiced = salesOrderListEntity.base_tax_invoiced;
			this.BaseTaxRefunded = salesOrderListEntity.base_tax_refunded;
			this.BaseToGlobalRate = salesOrderListEntity.base_to_global_rate;
			this.BaseToOrderRate = salesOrderListEntity.base_to_order_rate;
			this.BaseTotalCanceled = salesOrderListEntity.base_total_canceled;
			this.BaseTotalDue = salesOrderListEntity.base_total_due;
			this.BaseTotalInvoiced = salesOrderListEntity.base_total_invoiced;
			this.BaseTotalInvoicedCost = salesOrderListEntity.base_total_invoiced_cost;
			this.BaseTotalOfflineRefunded = salesOrderListEntity.base_total_offline_refunded;
			this.BaseTotalOnlineRefunded = salesOrderListEntity.base_total_online_refunded;
			this.BaseTotalPaid = salesOrderListEntity.base_total_paid;
			this.BaseTotalQtyOrdered = salesOrderListEntity.base_total_qty_ordered;
			this.BaseTotalRefunded = salesOrderListEntity.base_total_refunded;
			this.BillingAddressId = salesOrderListEntity.billing_address_id;
			this.BillingFirstname = salesOrderListEntity.billing_firstname;
			this.BillingLastname = salesOrderListEntity.billing_lastname;
			this.BillingName = salesOrderListEntity.billing_name;
			this.CanShipPartially = salesOrderListEntity.can_ship_partially;
			this.CanShipPartiallyItem = salesOrderListEntity.can_ship_partially_item;
			this.CouponCode = salesOrderListEntity.coupon_code;
			this.CreatedAt = salesOrderListEntity.created_at;
			this.CustomerBalanceAmount = salesOrderListEntity.customer_balance_amount;
			this.CustomerBalanceInvoiced = salesOrderListEntity.customer_balance_invoiced;
			this.CustomerBalanceRefunded = salesOrderListEntity.customer_balance_refunded;
			this.CustomerBalanceTotalRefunded = salesOrderListEntity.customer_balance_total_refunded;
			this.CustomerDob = salesOrderListEntity.customer_dob;
			this.CustomerEmail = salesOrderListEntity.customer_email;
			this.CustomerFirstname = salesOrderListEntity.customer_firstname;
			this.CustomerGender = salesOrderListEntity.customer_gender;
			this.CustomerGroupId = salesOrderListEntity.customer_group_id;
			this.CustomerId = salesOrderListEntity.customer_id;
			this.CustomerIsGuest = salesOrderListEntity.customer_is_guest;
			this.CustomerLastname = salesOrderListEntity.customer_lastname;
			this.CustomerMiddlename = salesOrderListEntity.customer_middlename;
			this.CustomerNote = salesOrderListEntity.customer_note;
			this.CustomerNoteNotify = salesOrderListEntity.customer_note_notify;
			this.CustomerPrefix = salesOrderListEntity.customer_prefix;
			this.CustomerSuffix = salesOrderListEntity.customer_suffix;
			this.CustomerTaxvat = salesOrderListEntity.customer_taxvat;
			this.DiscountAmount = salesOrderListEntity.discount_amount;
			this.DiscountCanceled = salesOrderListEntity.discount_canceled;
			this.DiscountDescription = salesOrderListEntity.discount_description;
			this.DiscountInvoiced = salesOrderListEntity.discount_invoiced;
			this.DiscountRefunded = salesOrderListEntity.discount_refunded;
			this.EditIncrement = salesOrderListEntity.edit_increment;
			this.EmailSent = salesOrderListEntity.email_sent;
			this.ExtCustomerId = salesOrderListEntity.ext_customer_id;
			this.ExtOrderId = salesOrderListEntity.ext_order_id;
			this.Firstname = salesOrderListEntity.firstname;
			this.ForcedDoShipmentWithInvoice = salesOrderListEntity.forced_do_shipment_with_invoice;
			this.GiftCards = salesOrderListEntity.gift_cards;
			this.GiftCardsAmount = salesOrderListEntity.gift_cards_amount;
			this.GiftCardsInvoiced = salesOrderListEntity.gift_cards_invoiced;
			this.GiftCardsRefunded = salesOrderListEntity.gift_cards_refunded;
			this.GiftMessageId = salesOrderListEntity.gift_message_id;
			this.GlobalCurrencyCode = salesOrderListEntity.global_currency_code;
			this.GrandTotal = salesOrderListEntity.grand_total;
			this.HiddenTaxAmount = salesOrderListEntity.hidden_tax_amount;
			this.HiddenTaxInvoiced = salesOrderListEntity.hidden_tax_invoiced;
			this.HiddenTaxRefunded = salesOrderListEntity.hidden_tax_refunded;
			this.HoldBeforeState = salesOrderListEntity.hold_before_state;
			this.HoldBeforeStatus = salesOrderListEntity.hold_before_status;
			this.incrementId = salesOrderListEntity.increment_id;
			this.IsVirtual = salesOrderListEntity.is_virtual;
			this.Lastname = salesOrderListEntity.lastname;
			this.OrderCurrencyCode = salesOrderListEntity.order_currency_code;
			this.OrderId = salesOrderListEntity.order_id;
			this.OriginalIncrementId = salesOrderListEntity.original_increment_id;
			this.PaymentAuthorizationAmount = salesOrderListEntity.payment_authorization_amount;
			this.PaymentAuthorizationExpiration = salesOrderListEntity.payment_authorization_expiration;
			this.PaypalIpnCustomerNotified = salesOrderListEntity.paypal_ipn_customer_notified;
			this.Postcode = salesOrderListEntity.postcode;
			this.ProtectCode = salesOrderListEntity.protect_code;
			this.QuoteAddressId = salesOrderListEntity.quote_address_id;
			this.QuoteId = salesOrderListEntity.quote_id;
			this.RelationChildId = salesOrderListEntity.relation_child_id;
			this.RelationChildRealId = salesOrderListEntity.relation_child_real_id;
			this.RelationParentId = salesOrderListEntity.relation_parent_id;
			this.RelationParentRealId = salesOrderListEntity.relation_parent_real_id;
			this.RemoteIp = salesOrderListEntity.remote_ip;
			this.RewardCurrencyAmount = salesOrderListEntity.reward_currency_amount;
			this.RewardCurrencyAmountInvoiced = salesOrderListEntity.reward_currency_amount_invoiced;
			this.RewardCurrencyAmountRefunded = salesOrderListEntity.reward_currency_amount_refunded;
			this.RewardPointsBalance = salesOrderListEntity.reward_points_balance;
			this.RewardPointsBalanceRefunded = salesOrderListEntity.reward_points_balance_refunded;
			this.RewardPointsBalanceToRefund = salesOrderListEntity.reward_points_balance_to_refund;
			this.RewardSalesrulePoints = salesOrderListEntity.reward_salesrule_points;
			this.ShippingAddressId = salesOrderListEntity.shipping_address_id;
			this.ShippingAmount = salesOrderListEntity.shipping_amount;
			this.ShippingCanceled = salesOrderListEntity.shipping_canceled;
			this.ShippingDescription = salesOrderListEntity.shipping_description;
			this.ShippingDiscountAmount = salesOrderListEntity.shipping_discount_amount;
			this.ShippingFirstname = salesOrderListEntity.shipping_firstname;
			this.ShippingHiddenTaxAmount = salesOrderListEntity.shipping_hidden_tax_amount;
			this.ShippingInclTax = salesOrderListEntity.shipping_incl_tax;
			this.ShippingInvoiced = salesOrderListEntity.shipping_invoiced;
			this.ShippingLastname = salesOrderListEntity.shipping_lastname;
			this.ShippingMethod = salesOrderListEntity.shipping_method;
			this.ShippingName = salesOrderListEntity.shipping_name;
			this.ShippingRefunded = salesOrderListEntity.shipping_refunded;
			this.ShippingTaxAmount = salesOrderListEntity.shipping_tax_amount;
			this.ShippingTaxRefunded = salesOrderListEntity.shipping_tax_refunded;
			this.State = salesOrderListEntity.state;
			this.Status = salesOrderListEntity.status;
			this.StoreCurrencyCode = salesOrderListEntity.store_currency_code;
			this.StoreId = salesOrderListEntity.store_id;
			this.StoreName = salesOrderListEntity.store_name;
			this.StoreToBaseRate = salesOrderListEntity.store_to_base_rate;
			this.StoreToOrderRate = salesOrderListEntity.store_to_order_rate;
			this.Subtotal = salesOrderListEntity.subtotal;
			this.SubtotalCanceled = salesOrderListEntity.subtotal_canceled;
			this.SubtotalInclTax = salesOrderListEntity.subtotal_incl_tax;
			this.SubtotalInvoiced = salesOrderListEntity.subtotal_invoiced;
			this.SubtotalRefunded = salesOrderListEntity.subtotal_refunded;
			this.TaxAmount = salesOrderListEntity.tax_amount;
			this.TaxCanceled = salesOrderListEntity.tax_canceled;
			this.TaxInvoiced = salesOrderListEntity.tax_invoiced;
			this.TaxRefunded = salesOrderListEntity.tax_refunded;
			this.Telephone = salesOrderListEntity.telephone;
			this.TotalCanceled = salesOrderListEntity.total_canceled;
			this.TotalDue = salesOrderListEntity.total_due;
			this.TotalInvoiced = salesOrderListEntity.total_invoiced;
			this.TotalItemCount = salesOrderListEntity.total_item_count;
			this.TotalOfflineRefunded = salesOrderListEntity.total_offline_refunded;
			this.TotalOnlineRefunded = salesOrderListEntity.total_online_refunded;
			this.TotalPaid = salesOrderListEntity.total_paid;
			this.TotalQtyOrdered = salesOrderListEntity.total_qty_ordered;
			this.TotalRefunded = salesOrderListEntity.total_refunded;
			this.UpdatedAt = salesOrderListEntity.updated_at;
			this.Weight = salesOrderListEntity.weight;
			this.XForwardedFOR = salesOrderListEntity.x_forwarded_for;
		}

		public string AdjustmentNegative { get; private set; }
		public string AdjustmentPositive { get; private set; }
		public string AppliedRuleIds { get; private set; }
		public string BaseAdjustmentNegative { get; private set; }
		public string BaseAdjustmentPositive { get; private set; }
		public string BaseCurrencyCode { get; private set; }
		public string BaseCustomerBalanceAmount { get; private set; }
		public string BaseCustomerBalanceInvoiced { get; private set; }
		public string BaseCustomerBalanceRefunded { get; private set; }
		public string BaseCustomerBalanceTotalRefunded { get; private set; }
		public string BaseDiscountAmount { get; private set; }
		public string BaseDiscountCanceled { get; private set; }
		public string BaseDiscountInvoiced { get; private set; }
		public string BaseDiscountRefunded { get; private set; }
		public string BaseGiftCardsAmount { get; private set; }
		public string BaseGiftCardsInvoiced { get; private set; }
		public string BaseGiftCardsRefunded { get; private set; }
		public string BaseGrandTotal { get; private set; }
		public string BaseHiddenTaxAmount { get; private set; }
		public string BaseHiddenTaxInvoiced { get; private set; }
		public string BaseHiddenTaxRefunded { get; private set; }
		public string BaseRewardCurrencyAmount { get; private set; }
		public string BaseRewardCurrencyAmountInvoiced { get; private set; }
		public string BaseRewardCurrencyAmountRefunded { get; private set; }
		public string BaseShippingAmount { get; private set; }
		public string BaseShippingCanceled { get; private set; }
		public string BaseShippingDiscountAmount { get; private set; }
		public string BaseShippingHiddenTaxAmount { get; private set; }
		public string BaseShippingInclTax { get; private set; }
		public string BaseShippingInvoiced { get; private set; }
		public string BaseShippingRefunded { get; private set; }
		public string BaseShippingTaxAmount { get; private set; }
		public string BaseShippingTaxRefunded { get; private set; }
		public string BaseSubtotal { get; private set; }
		public string BaseSubtotalCanceled { get; private set; }
		public string BaseSubtotalInclTax { get; private set; }
		public string BaseSubtotalInvoiced { get; private set; }
		public string BaseSubtotalRefunded { get; private set; }
		public string BaseTaxAmount { get; private set; }
		public string BaseTaxCanceled { get; private set; }
		public string BaseTaxInvoiced { get; private set; }
		public string BaseTaxRefunded { get; private set; }
		public string BaseToGlobalRate { get; private set; }
		public string BaseToOrderRate { get; private set; }
		public string BaseTotalCanceled { get; private set; }
		public string BaseTotalDue { get; private set; }
		public string BaseTotalInvoiced { get; private set; }
		public string BaseTotalInvoicedCost { get; private set; }
		public string BaseTotalOfflineRefunded { get; private set; }
		public string BaseTotalOnlineRefunded { get; private set; }
		public string BaseTotalPaid { get; private set; }
		public string BaseTotalQtyOrdered { get; private set; }
		public string BaseTotalRefunded { get; private set; }
		public string BillingAddressId { get; private set; }
		public string BillingFirstname { get; private set; }
		public string BillingLastname { get; private set; }
		public string BillingName { get; private set; }
		public string CanShipPartially { get; private set; }
		public string CanShipPartiallyItem { get; private set; }
		public string CouponCode { get; private set; }
		public string CreatedAt { get; private set; }
		public string CustomerBalanceAmount { get; private set; }
		public string CustomerBalanceInvoiced { get; private set; }
		public string CustomerBalanceRefunded { get; private set; }
		public string CustomerBalanceTotalRefunded { get; private set; }
		public string CustomerDob { get; private set; }
		public string CustomerEmail { get; private set; }
		public string CustomerFirstname { get; private set; }
		public string CustomerGender { get; private set; }
		public string CustomerGroupId { get; private set; }
		public string CustomerId { get; private set; }
		public string CustomerIsGuest { get; private set; }
		public string CustomerLastname { get; private set; }
		public string CustomerMiddlename { get; private set; }
		public string CustomerNote { get; private set; }
		public string CustomerNoteNotify { get; private set; }
		public string CustomerPrefix { get; private set; }
		public string CustomerSuffix { get; private set; }
		public string CustomerTaxvat { get; private set; }
		public string DiscountAmount { get; private set; }
		public string DiscountCanceled { get; private set; }
		public string DiscountDescription { get; private set; }
		public string DiscountInvoiced { get; private set; }
		public string DiscountRefunded { get; private set; }
		public string EditIncrement { get; private set; }
		public string EmailSent { get; private set; }
		public string ExtCustomerId { get; private set; }
		public string ExtOrderId { get; private set; }
		public string Firstname { get; private set; }
		public string ForcedDoShipmentWithInvoice { get; private set; }
		public string GiftCards { get; private set; }
		public string GiftCardsAmount { get; private set; }
		public string GiftCardsInvoiced { get; private set; }
		public string GiftCardsRefunded { get; private set; }
		public string GiftMessageId { get; private set; }
		public string GlobalCurrencyCode { get; private set; }
		public string GrandTotal { get; private set; }
		public string HiddenTaxAmount { get; private set; }
		public string HiddenTaxInvoiced { get; private set; }
		public string HiddenTaxRefunded { get; private set; }
		public string HoldBeforeState { get; private set; }
		public string HoldBeforeStatus { get; private set; }
		public string incrementId { get; private set; }
		public string IsVirtual { get; private set; }
		public string Lastname { get; private set; }
		public string OrderCurrencyCode { get; private set; }
		public string OrderId { get; private set; }
		public string OriginalIncrementId { get; private set; }
		public string PaymentAuthorizationAmount { get; private set; }
		public string PaymentAuthorizationExpiration { get; private set; }
		public string PaypalIpnCustomerNotified { get; private set; }
		public string Postcode { get; private set; }
		public string ProtectCode { get; private set; }
		public string QuoteAddressId { get; private set; }
		public string QuoteId { get; private set; }
		public string RelationChildId { get; private set; }
		public string RelationChildRealId { get; private set; }
		public string RelationParentId { get; private set; }
		public string RelationParentRealId { get; private set; }
		public string RemoteIp { get; private set; }
		public string RewardCurrencyAmount { get; private set; }
		public string RewardCurrencyAmountInvoiced { get; private set; }
		public string RewardCurrencyAmountRefunded { get; private set; }
		public string RewardPointsBalance { get; private set; }
		public string RewardPointsBalanceRefunded { get; private set; }
		public string RewardPointsBalanceToRefund { get; private set; }
		public string RewardSalesrulePoints { get; private set; }
		public string ShippingAddressId { get; private set; }
		public string ShippingAmount { get; private set; }
		public string ShippingCanceled { get; private set; }
		public string ShippingDescription { get; private set; }
		public string ShippingDiscountAmount { get; private set; }
		public string ShippingFirstname { get; private set; }
		public string ShippingHiddenTaxAmount { get; private set; }
		public string ShippingInclTax { get; private set; }
		public string ShippingInvoiced { get; private set; }
		public string ShippingLastname { get; private set; }
		public string ShippingMethod { get; private set; }
		public string ShippingName { get; private set; }
		public string ShippingRefunded { get; private set; }
		public string ShippingTaxAmount { get; private set; }
		public string ShippingTaxRefunded { get; private set; }
		public string State { get; private set; }
		public string Status { get; private set; }
		public string StoreCurrencyCode { get; private set; }
		public string StoreId { get; private set; }
		public string StoreName { get; private set; }
		public string StoreToBaseRate { get; private set; }
		public string StoreToOrderRate { get; private set; }
		public string Subtotal { get; private set; }
		public string SubtotalCanceled { get; private set; }
		public string SubtotalInclTax { get; private set; }
		public string SubtotalInvoiced { get; private set; }
		public string SubtotalRefunded { get; private set; }
		public string TaxAmount { get; private set; }
		public string TaxCanceled { get; private set; }
		public string TaxInvoiced { get; private set; }
		public string TaxRefunded { get; private set; }
		public string Telephone { get; private set; }
		public string TotalCanceled { get; private set; }
		public string TotalDue { get; private set; }
		public string TotalInvoiced { get; private set; }
		public string TotalItemCount { get; private set; }
		public string TotalOfflineRefunded { get; private set; }
		public string TotalOnlineRefunded { get; private set; }
		public string TotalPaid { get; private set; }
		public string TotalQtyOrdered { get; private set; }
		public string TotalRefunded { get; private set; }
		public string UpdatedAt { get; private set; }
		public string Weight { get; private set; }
		public string XForwardedFOR { get; private set; }
	}
}