using DesafioPOO.Models;


            Nokia nokiaPhone = new Nokia("123456", "Nokia XYZ", "IMEI123", 64);
            nokiaPhone.Ligar();
            nokiaPhone.InstalarAplicativo("WhatsApp");
            

            Console.WriteLine("\n");

            
            Iphone iphone = new Iphone("789012", "iPhone 12", "IMEI456", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
