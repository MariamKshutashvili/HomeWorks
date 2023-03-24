using System;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace Homework__12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Factory
                     
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("N1 Abstract Factory");
            Console.ResetColor();
            Console.WriteLine("\nArt Deco:");

            Client client = new Client(new ArtDecoFactory());
            client.Run();
            Console.WriteLine("\nVictorian:");

            Client client2 = new Client(new VictorianFactory());
            client2.Run();
            Console.WriteLine("\nModern:");

            Client client3 = new Client(new ModernFactory());
            client3.Run();
            Console.WriteLine("\n");
            #endregion


            #region Proxy Pattern

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("N2 Proxy Pattern");
            Console.ResetColor();

            Actors subject = new Stuntman();
            Console.WriteLine("Stuntman");
            subject.Request();


            MainActor realSubject = new MainActor();
            Console.WriteLine($"\nMain Actor");

            realSubject.Request();

            #endregion


            #region Facade

            Console.WriteLine("\n\n");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("N3 Facade");
            Console.ResetColor();


            Facade facade = new Facade();
            facade.OperationHTML();
            Console.WriteLine(new string('-', 40));
            facade.OperationPDF();
            Console.WriteLine(new string('-', 40));

            #endregion
        }

        #region Solution1 
        public abstract class AbstractChair
        {
        }
        public abstract class AbstractFactory
        {
            public abstract AbstractChair CreateChair();
            public abstract AbstractSofa CreateSofa();
            public abstract AbstractTable CreateTable();

        }

        public abstract class AbstractSofa
        {
            public abstract void Interact(AbstractChair chair);
        }

        public abstract class AbstractTable
        {
            public abstract void Interact(AbstractSofa sofa, AbstractChair chair);
        }
        class ArtDecoSofa : AbstractSofa
        {
            public override void Interact(AbstractChair chair)
            {
                Console.WriteLine(this + " interacts with " + chair);
            }
        }
        //artDeco 
        class ArtDecoTable : AbstractTable
        {
            public override void Interact(AbstractSofa sofa, AbstractChair chair)
            {
                Console.WriteLine(this + " interacts with " + sofa +" and" +chair);
            }
        }


        class ArtDecoChair : AbstractChair
        {
        }

        class ArtDecoFactory : AbstractFactory
        {
            public override AbstractChair CreateChair()
            {
                return new ArtDecoChair();
            }

            public override AbstractSofa CreateSofa()
            {
                return new ArtDecoSofa();

            }

            public override AbstractTable CreateTable()
            {
                return new ArtDecoTable();
            }

        }
        //Victorian
        class VictorianSofa : AbstractSofa
        {
            public override void Interact(AbstractChair chair)
            {
                Console.WriteLine(this + " interacts with " + chair);
            }
        }
        class VictorianTable : AbstractTable
        {
            public override void Interact(AbstractSofa sofa, AbstractChair chair)
            {
                Console.WriteLine(this + " interacts with " + sofa +" and "+chair);
            }
        }

        class VictorianChair : AbstractChair
        {
        }

        class VictorianFactory : AbstractFactory
        {
            public override AbstractChair CreateChair()
            {
                return new VictorianChair();
            }

            public override AbstractSofa CreateSofa()
            {
                return new VictorianSofa();

            }

            public override AbstractTable CreateTable()
            {
                return new VictorianTable();
            }

        }

        //Modern
        class ModernSofa : AbstractSofa
        {
            public override void Interact(AbstractChair chair)
            {
                Console.WriteLine(this + " interacts with " + chair);
            }
        }

        class ModernTable : AbstractTable
        {
            public override void Interact(AbstractSofa sofa, AbstractChair chair)
            {
                Console.WriteLine(this + " interacts with " + sofa +" and " +chair);
            }
        }


        class ModernChair : AbstractChair
        {
        }

        class ModernFactory : AbstractFactory
        {
            public override AbstractChair CreateChair()
            {
                return new ModernChair();
            }

            public override AbstractSofa CreateSofa()
            {
                return new ModernSofa();

            }

            public override AbstractTable CreateTable()
            {
                return new ModernTable();
            }

        }

        public class Client
        {
            private AbstractChair chair;
            private AbstractSofa sofa;
            private AbstractTable table;
            public Client(AbstractFactory factory)
            {
                chair = factory.CreateChair();
                sofa = factory.CreateSofa();
                table = factory.CreateTable();
            }
            public void Run()
            {
                sofa.Interact(chair);
                table.Interact(sofa,chair);
            }
        }

        #endregion


        #region Solution2

        abstract class Actors
        {
            public abstract void Request();
        }
        class MainActor : Actors
        {
            public override void Request()
            {
                Console.WriteLine("I am mostly in the shots of the main scenes");
            }
        }
        class Stuntman : Actors
        {
            MainActor role;
            public override void Request()
            {
                if (role == null)
                    role = new MainActor();
                role.Request();
                Console.WriteLine("And I am also in life-threatening scenes");
            }
        }
        #endregion


        #region Solution3
        class Facade
        {
            Header subSystemA = new Header();
            Body subSystemB = new Body();
            Footer subSystemC = new Footer();
            public void OperationHTML()
            {
                subSystemA.GetHeaderHTML();
                subSystemB.GetbodyHTML();
                subSystemC.GetfooterHTML();                
            }
            public void OperationPDF()
            {
                subSystemA.GetHeaderPDF();
                subSystemB.GetbodyPDF();
                subSystemC.GetfooterPDF();
            }
        }

        class Header
        {
            public void GetHeaderHTML()
            {
                Console.WriteLine("<header> My Header </header>\n");
            }

            public void GetHeaderPDF()
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Header");
                Console.ResetColor();
                Console.WriteLine(" : I’m using Facade Pattern\n");
            }
        }

        class Body
        {
            public void GetbodyHTML()
            {
                Console.WriteLine("<body>");
                Console.WriteLine("Video provides a powerful way to help you prove" +
                    " your point. When you click\r\nOnline Video, you can paste in the" +
                    " embed code for the video you want to add.");
                Console.WriteLine("</body\n");
            }
            public void GetbodyPDF()
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Body");
                Console.ResetColor();

                Console.WriteLine(" : \nVideo provides a powerful way to help you prove " +
                    "your point. When you click\r\nOnline Video, you can paste in the" +
                    " embed code for the video you want to add.\r\nYou can also type a" +
                    " keyword to search online for the video that best fits your\r\ndocument. To make " +
                    "your document look professionally produced, Word provides\n");           
            }
        }

        class Footer
        {
            public void GetfooterHTML()
            {
                Console.WriteLine("<footer> My footer </footer");
            }

            public void GetfooterPDF()
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("Footer");
                Console.ResetColor();

                Console.WriteLine(" : Page 1");          

            }
            

        }
        #endregion

    }

   
}
