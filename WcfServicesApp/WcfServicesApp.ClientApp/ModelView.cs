namespace WcfServicesApp.ClientApp
{
    public class Order
    {
        public string ORDER_NO { get; set; }
        public string STATUS { get; set; }
        public string ORDER_DAT { get; set; }
        public string ORDER_TIM { get; set; }
        public string ORDER_OPTR { get; set; }
        public string EXP_RCV_DAT { get; set; }
        public string WH_CODE { get; set; }
        public string TYPE_CODE { get; set; }
        public string BP_CODE { get; set; }
        public string TOTAL { get; set; }
        public string APV_DAT { get; set; }
        public string APV_TIM { get; set; }
        public string APV_OPTR { get; set; }
        public string DCS_DAT { get; set; }
        public string DCS_TIM { get; set; }
        public string DCS_OPTR { get; set; }
        public string RMRK1 { get; set; }
        public string RMRK2 { get; set; }
        public string REASON { get; set; }
        public string ACTFLG { get; set; }
        public string CTDUSR { get; set; }


        public string CTDWKS { get; set; }
        public string CTDPGM { get; set; }
        public string CTDDTM { get; set; }
        public string MDFUSR { get; set; }
        public string MDFWKS { get; set; }
        public string MDFPGM { get; set; }
        public string LSTMDF { get; set; }
    }

    public class OrderDetails
    {
        public string ORDER_NO { get; set; }
        public string PART_NO { get; set; }
        public string LINE_NO { get; set; }
        public string STATUS { get; set; }
        public string BO_FLAG { get; set; }
        public string QTY { get; set; }
        public string PRICE { get; set; }
        public string LINE_TOTAL { get; set; }
        public string ALL_QTY { get; set; }
        public string DLV_QTY { get; set; }
        public string OO_QTY { get; set; }
        public string STOCK_QTY { get; set; }
        public string CANCEL_QTY { get; set; }
        public string FNO { get; set; }
        public string REASON { get; set; }
        public string ACTFLG { get; set; }
        public string CTDUSR { get; set; }
        public string CTDWKS { get; set; }
        public string CTDPGM { get; set; }
        public string CTDDTM { get; set; }
        public string MDFUSR { get; set; }


        public string MDFWKS { get; set; }
        public string MDFPGM { get; set; }
        public string LSTMDF { get; set; }
    }
}
