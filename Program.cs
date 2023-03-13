using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;
            int y=2;
            int sonuc=ArtTop(ref x,ref y);//parametre fonksyon içindeki işleme göre kalıcı değer alır
            Console.WriteLine(sonuc+" "+x+"+"+y);

            Formuller formul=new Formuller();
            formul.Yazdir(formul.Topla(10,5));
        }


        public static int ArtTop(ref int x,ref int y){ // bu şekilde ref yazılarak parametre değişikliği kalıcı olur
            x=x+2;
            y=y+6;
            return (x+y);
        }

        
        
    }

    class Formuller{

        public void Yazdir(int val){

            Console.WriteLine("sonuc:"+val);

        }
        public int Topla(int a,int b){


            return a+b;
        }

    }  
}