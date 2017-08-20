using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApptest1
{
   public class LVString
    {
       public string PINKeyNo;
       public string MACKeyNo;
       public string TerminalID;
       public string MerchantID;
       public string Amount;
       public string CardNumber;       
       public string CardPIN;
       public string CardTrack2;

       public string ProcessingCode;

      
       public string Wholestring;
       public void CreateLVString()
       {
           int WholeLen;

           WholeLen = PINKeyNo.Length + MACKeyNo.Length + TerminalID.Length + MerchantID.Length + Amount.Length + CardNumber.Length + CardPIN.Length + CardTrack2.Length;

           WholeLen = WholeLen + 8;

           Wholestring = WholeLen.ToString()+PINKeyNo.Length + PINKeyNo
                         + MACKeyNo.Length + MACKeyNo
                         +TerminalID.Length+TerminalID
                         +MerchantID.Length+MerchantID
                         + Amount.Length + Amount
                         + CardNumber.Length + CardNumber                      
                         + CardPIN.Length + CardPIN
                         +CardTrack2.Length + CardTrack2;


       }

       //public CommonSwitch.Transaction.TransactionField getCurrentTrx()
       //{

       //    CommonSwitch.Transaction.TransactionField result = new CommonSwitch.Transaction.TransactionField() ;
       //    result.TrxGenType = CommonSwitch.Transaction.Definition_Transaction.Def_TrxType_Gen.Finance;
       
       //    result.Data.Add(2,this.CardNumber);
       //    result.Data.Add(3,this.)


       //    return result;
       //}
   
   }
}
