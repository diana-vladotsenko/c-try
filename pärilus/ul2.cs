using System;
namespace Parilus3{
 class Inimene{
   protected int vanus;
   public Inimene(int uvanus){
      vanus=uvanus;
   }
   public virtual void YtleVanus(){
      Console.WriteLine("Minu vanus on "+vanus+" aastat");
   }
   public virtual void KutsuEttekandja(){
   	Console.WriteLine("Ettekandja!");
   }
 }
 class Daam:Inimene {
   public Daam(int vanus):base(vanus){}
   public override void YtleVanus(){
      Console.WriteLine("Minu vanus on "+(vanus-5)+" aastat");
   }
   public override void KutsuEttekandja(){
      Console.WriteLine("ETTEKANDJA!!");
   }
   
 }
 class InimTest{
  public static void Main(string[] arg){
     Inimene inim1=new Inimene(40);
     Daam inim2=new Daam(60);
     inim1.YtleVanus();
     inim2.YtleVanus();
     inim1.KutsuEttekandja();
     inim2.KutsuEttekandja();
     
     
     
  }
 }
}
//override - votab mingi funktsiooni ja переписываешь/переназначаешь
