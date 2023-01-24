using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EShop
{
    public class EShopMain
    {
        #region Variables
        public string userChoice;
        public int sumOfPrices;
        public int userNumberItem;
        public int orderTotal;

        public double userbudget;
        public List<Item> jordan;
        public List<Item> nike;
        public List<Item> adidas;
        public List<Item> shopCart;
        public List<int> shopCartPrices;
        public List<int> duplicatePrices;
        #endregion

        public static void Main(string[] arg)
        {
            EShopMain ems = new EShopMain();
            ems.StartScreen();
        }

        //#region Inicializar variables
        public void Init()
        {
            jordan = Item.AllJoradan();
            nike = Item.AllNike();
            adidas = Item.AllAdidas();
            shopCart = new List<Item>();
            userbudget = GetBudget();
            orderTotal = 0;
           
            shopCartPrices = new List<int>();
            
        }
        //#endregion
    




        //#region Pagina de Bienvenida
        public void StartScreen()
        {
            Init();

            //Console.WriteLine($"\n\n El budget fue seleccionado fue:${GetBudget()}");
            
            Console.Clear();
            Console.WriteLine("Welcome William A.Rosado");
            Console.WriteLine();
            Console.WriteLine("Autor: William A.Rosado");
            Console.WriteLine("Version:1.0");
            Console.WriteLine("Last Revised:2022-12-7");
            Console.WriteLine();
            Console.WriteLine("Description: Shoe shot is shop you can buy some shoe.");
            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
            Console.Clear();
                
           


            Console.WriteLine("Welcome to Shoe shot E-Shop William A.Rosado!");
            Console.WriteLine("");
            Console.WriteLine("Your badge:" + "$" + userbudget);
            Console.WriteLine();
            Console.WriteLine("[S]-Start shopping!");
            Console.WriteLine("[X]-Exit");
         
            StartScreenOptions();
        }
        //#endregion

        //#region Menu Principal
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0,20}", "Main Menu\n"));
            Console.WriteLine("Thank you for visiting Shoe shot William A.Rosado!");
            Console.WriteLine("To see your budget go to the shopping cart section if you want.\n");
            Console.Write("[C]-View the Catalog | ");
            Console.Write("[V]-View Shop Cart | ");
            Console.WriteLine("[X] Exit.");
            Console.WriteLine("");
            Console.WriteLine("Your budget:" +  userbudget);
            Console.WriteLine();
            Console.WriteLine("Your order total:" + "$" +  orderTotal );
            Console.WriteLine();
            Console.WriteLine("Your balance:" + "$" + userbudget , orderTotal);
            MenuOptions();
        }
        //#endregion

        //#region Catalogo de la tienda
        public void Catalog()
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0,20}", "CATALOG\n"));
            Console.WriteLine("[J]-Jordan");
            Console.WriteLine("[N]-Nike");
            Console.WriteLine("[A]-Adidas\n");
            Console.WriteLine("[R]-Return to previous page");
            Console.WriteLine("[X]-Exit");
            Console.WriteLine();
            Console.WriteLine("Your budget:" + "$" + userbudget);
            Console.WriteLine();
            Console.WriteLine("Your balance:" + "$" + userbudget , orderTotal);
            Console.WriteLine();
            CatalogOptions();
        }
        //#endregion

        //#region Carrito de compra
        public void ShopCart()
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0,30}", "BUDGET AND CART\n"));
            Console.WriteLine("Your budget is: " + string.Format("{0:C2}", userbudget));
            Console.WriteLine();
            Console.WriteLine(string.Format("{0,25}", "CART \n"));

            if (shopCart.Count != 0)
            {
                Console.WriteLine(string.Format("{0,30}", "Items and price\n"));
                for (int i = 0; i < shopCart.Count; i++)
                {
                    Console.WriteLine(string.Format("[#{0,1:0}] {1}", i, shopCart[i].CarrView()));
                }
            }
            else
            {
                Console.WriteLine(string.Format("{0,28}", "Cart is empty!"));
            }

            sumOfPrices = shopCartPrices.Sum();
            orderTotal = sumOfPrices;

            Console.WriteLine();
            Console.WriteLine("Total: " + "$" + orderTotal);
            Console.WriteLine("=========================================");
            Console.WriteLine("             [C]-CheckOut       ");
            Console.WriteLine("=========================================");
            Console.WriteLine("[A]-Add another item | [X]-Eliminate item");
            Console.WriteLine("=========================================");
            Console.WriteLine("          [R]-Return to menu");
            Console.WriteLine("=========================================");

            CartOptions();
        }
        //#endregion

        //#region Productos 
        public void AllShoeJordan()
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0,30}", "Jordan\n"));
            Console.WriteLine(string.Format("{0,2} {1,10} {2,26} {3,8} {4}", "#", "Item", "Price", "Stock", "In ShopCart"));

            for (int i = 0; i < jordan.Count; i++)
            {
                Console.WriteLine(string.Format("[J{0,1:0}] {1}", i, jordan[i].ListView()));
            }
            Console.WriteLine();
            Console.WriteLine("Your budget: " + "$" + userbudget);
            Console.WriteLine();
            Console.Write("[A]-Add Item to cart | ");
            Console.Write("[V]-View Shop Cart | ");
            Console.WriteLine("[R]-Return to previous page");
            Console.WriteLine();
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                if (userChoice == "A")
                {
                    Console.WriteLine();
                    AddJordanToCart();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "R")
                {
                    Catalog();
                    break;
                }

            } while (userChoice != "A" || userChoice != "R" || userChoice != "V");
        }

        public void AllShoeNike()
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0,30}", "Nike\n"));
            Console.WriteLine(string.Format("{0,2} {1,10} {2,26} {3,8} {4}", "#", "Item", "Price", "Stock", "In ShopCart"));

            for (int i = 0; i < nike.Count; i++)
            {
                Console.WriteLine(string.Format("[N{0,1:0}] {1}", i, nike[i].ListView()));
            }
            Console.WriteLine();
            Console.WriteLine("Your badge:" + "$" + userbudget);
            Console.WriteLine();
            Console.Write("[A]-Add Item to cart | ");
            Console.Write("[V]- View Shop Cart | ");
            Console.WriteLine("[R]-Return to previous page");
            Console.WriteLine();
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                if (userChoice == "A")
                {
                    Console.WriteLine();
                    AddNikeToCart();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "R")
                {
                    Catalog();
                    break;
                }
            } while (userChoice != "A" || userChoice != "R" || userChoice != "V");
        }

        public void AllShoeAdidas()
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0,30}", "Adidas\n"));
            Console.WriteLine(string.Format("{0,2} {1,10} {2,26} {3,8} {4}", "#", "Item", "Price", "Stock", "In ShopCart"));

            for (int i = 0; i < adidas.Count; i++)
            {
                Console.WriteLine(string.Format("[A{0,1:0}] {1}", i, adidas[i].ListView()));
            }
            Console.WriteLine();
            Console.WriteLine("Your badge:" + "$" + userbudget);
            Console.WriteLine();
            Console.Write("[A]-Add Item to cart | ");
            Console.Write("[V]-View Shop Cart | ");
            Console.WriteLine("[R]-Return to previous page");
            Console.WriteLine();
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                if (userChoice == "A")
                {
                    Console.WriteLine();
                    AddAdidasToCart();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "R")
                {
                    Catalog();
                    break;
                }
            } while (userChoice != "A" || userChoice != "R" || userChoice != "V");
        }
        //#endregion

        //#region Añadir los objetos al carrito
        public void AddJordanToCart()
        {
            Console.WriteLine("Adding Item to the cart");
            Console.WriteLine("Note: enter only the number in front of the J\n");
            userNumberItem = GetNumberItem("Enter the #: ");

            if (jordan[0].stockQuantity != 0 && userNumberItem == 0)
            {
                shopCart.Add(jordan[0]);
                shopCartPrices.Add(jordan[0].price);
                jordan[0].cartQuantity++;
                jordan[0].stockQuantity--;
                Console.WriteLine("Item selected: " + jordan[0].name +  " $" + jordan[0].price);
                Console.WriteLine("Your order:" +" $"+ jordan[0].price );
               
            }
            else if (jordan[1].stockQuantity != 0 && userNumberItem == 1)
            {
                shopCart.Add(jordan[1]);
                shopCartPrices.Add(jordan[1].price);
                jordan[1].cartQuantity++;
                jordan[1].stockQuantity--;
                Console.WriteLine("Item selected: " + jordan[1].name + " $" + jordan[0].price);
                Console.WriteLine("Your order:" +" $"+ jordan[1].price );
            }
            else if (jordan[2].stockQuantity != 0 && userNumberItem == 2)
            {
                shopCart.Add(jordan[2]);
                shopCartPrices.Add(jordan[2].price);
                jordan[2].cartQuantity++;
                jordan[2].stockQuantity--;
                Console.WriteLine("Item selected: " + jordan[2].name +" $"+ jordan[2].price );
                Console.WriteLine("Your order:" + " $" + jordan[2].price);
                //Console.WriteLine("$" + jordan[2].price);
            }

            else if (jordan[3].stockQuantity != 0 && userNumberItem == 3)
            {
                shopCart.Add(jordan[3]);
                shopCartPrices.Add(jordan[3].price);
                jordan[3].cartQuantity++;
                jordan[3].stockQuantity--;
                Console.WriteLine("Item selected: " + jordan[3].name +" $" + jordan[3].price);
                Console.WriteLine("Your order:" + " $" + jordan[3].price);
            }

            else if (jordan[4].stockQuantity != 0 && userNumberItem == 4)
            {
                shopCart.Add(jordan[4]);
                shopCartPrices.Add(jordan[4].price);
                jordan[3].cartQuantity++;
                jordan[3].stockQuantity--;
                Console.WriteLine("Item selected: " + jordan[4].name + " $" + jordan[4].price);
                Console.WriteLine("Your order:" + " $" + jordan[4].price);
            }


            else
            {
                Console.WriteLine("This item is out of stock or dont exists");
            }

            AddAnotherJordan();

        }

        public void AddNikeToCart()
        {
            Console.WriteLine("Adding Item to the cart");
            Console.WriteLine("Note: enter only the number in front of the N\n");
            userNumberItem = GetNumberItem("Enter the #: ");

            if (nike[0].stockQuantity != 0 && userNumberItem == 0)
            {
                shopCart.Add(nike[0]);
                shopCartPrices.Add(nike[0].price);
                nike[0].cartQuantity++;
                nike[0].stockQuantity--;
                Console.WriteLine("Item selected: " + nike[0].name + " $" + nike[0].price );
                Console.WriteLine("Your order:" + " $" + nike[0].price);
            }
            else if (nike[1].stockQuantity != 0 && userNumberItem == 1)
            {
                shopCart.Add(nike[1]);
                shopCartPrices.Add(nike[1].price);
                nike[1].cartQuantity++;
                nike[1].stockQuantity--;
                Console.WriteLine("Item selected: " + nike[1].name + " $" + nike[1].price);
                Console.WriteLine("Your order:" + " $" + nike[1].price);
            }
            else if (nike[2].stockQuantity != 0 && userNumberItem == 2)
            {
                shopCart.Add(nike[2]);
                shopCartPrices.Add(nike[2].price);
                nike[2].cartQuantity++;
                nike[2].stockQuantity--;
                Console.WriteLine("Item selected: " + nike[2].name + " $" + nike[2].price);
                Console.WriteLine("Your order:" + " $" + nike[2].price);
            }
            else if (nike[3].stockQuantity != 0 && userNumberItem == 3)
            {
                shopCart.Add(nike[3]);
                shopCartPrices.Add(nike[3].price);
                nike[3].cartQuantity++;
                nike[3].stockQuantity--;
                Console.WriteLine("Item selected: " + nike[3].name + " $" + jordan[3].price);
                Console.WriteLine("Your order:" + " $" + nike[3].price);
            }
            else
            {
                Console.WriteLine("This item is out of stock or dont exists");
            }

            AddAnotherNike();
        }

        public void AddAdidasToCart()
        {
            Console.WriteLine("Adding Item to the cart");
            Console.WriteLine("Note: enter only the number in front of the A\n");
            userNumberItem = GetNumberItem("Enter the #: ");
            if (adidas[0].stockQuantity != 0 && userNumberItem == 0)
            {
                shopCart.Add(adidas[0]);
                shopCartPrices.Add(adidas[0].price);
                adidas[0].cartQuantity++;
                adidas[0].stockQuantity--;
                Console.WriteLine("Item selected: " + adidas[0].name + " $" + adidas[0].price);
                Console.WriteLine("Your order:" + " $" + adidas[0].price);
            }
            else if (adidas[1].stockQuantity != 0 && userNumberItem == 1)
            {
                shopCart.Add(adidas[1]);
                shopCartPrices.Add(adidas[1].price);
                adidas[1].cartQuantity++;
                adidas[1].stockQuantity--;
                Console.WriteLine("Item selected: " + adidas[1].name + " $" + adidas[1].price);
                Console.WriteLine("Your order:" + " $" + adidas[1].price);
            }
            else if (adidas[2].stockQuantity != 0 && userNumberItem == 2)
            {
                shopCart.Add(adidas[2]);
                shopCartPrices.Add(adidas[2].price);
                adidas[2].cartQuantity++;
                adidas[2].stockQuantity--;
                Console.WriteLine("Item selected: " + adidas[2].name + " $" + adidas[2].price);
                Console.WriteLine("Your order:" + " $" + adidas[2].price);
            }
            else if (adidas[3].stockQuantity != 0 && userNumberItem == 3)
            {
                shopCart.Add(adidas[3]);
                shopCartPrices.Add(adidas[3].price);
                adidas[3].cartQuantity++;
                adidas[3].stockQuantity--;
                Console.WriteLine("Item selected: " + adidas[3].name + " $" + adidas[3].price);
                Console.WriteLine("Your order:" + " $" + adidas[3].price);
            }
            else if (adidas[4].stockQuantity != 0 && userNumberItem == 4)
            {
                shopCart.Add(adidas[4]);
                shopCartPrices.Add(adidas[4].price);
                adidas[4].cartQuantity++;
                adidas[4].stockQuantity--;
                Console.WriteLine("Item selected: " + adidas[4].name + " $" + adidas[4].price);
                Console.WriteLine("Your order:" + " $" + adidas[4].price);
            }

            else if (adidas[5].stockQuantity != 0 && userNumberItem == 5)
            {
                shopCart.Add(adidas[5]);
                shopCartPrices.Add(adidas[5].price);
                adidas[5].cartQuantity++;
                adidas[5].stockQuantity--;
                Console.WriteLine("Item selected: " + adidas[5].name + " $" + adidas[5].price);
                Console.WriteLine("Your order:" + " $" + adidas[5].price);
            }





            else
            {
                Console.WriteLine("I can't find this item");
            }

            AddAnotherAdidas();

        }
        //#endregion

        //#region Opciones que aparecen en las paginas
        public void StartScreenOptions()
        {
            Console.WriteLine();
            do
            {
                userChoice = GetUserChoice("Select an option: ");

                if (userChoice == "S")
                {
                    Menu();
                    break;
                }
                else if (userChoice == "X")
                {
                    ExitTheShop();
                    break;
                }

                Console.WriteLine("Error: Please enter the letter in the box");
            } while (userChoice != "S" || userChoice != "X");
        }

        public void MenuOptions()
        {
            Console.WriteLine();
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                if (userChoice == "C")
                {
                    Catalog();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "X")
                {
                    ExitTheShop();
                    break;
                }
                Console.WriteLine("Error: Please enter the letter in the box");
            } while (userChoice != "V" || userChoice != "X" || userChoice != "B");
        }

        public void CatalogOptions()
        {
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                Console.WriteLine("Your badge:" + "$" + userbudget + orderTotal);
                Console.WriteLine();
                if (userChoice == "J")
                {
                    AllShoeJordan();
                    break;
                }
                else if (userChoice == "N")
                {
                    AllShoeNike();
                    break;
                }
                else if (userChoice == "A")
                {
                    AllShoeAdidas();
                    break;
                }
                else if (userChoice == "R")
                {
                    Menu();
                    break;
                }
                else if (userChoice == "X")
                {
                    ExitTheShop();
                    break;
                }
                Console.WriteLine("Error: Please enter the letter in the box");
            } while (userChoice != "C" || userChoice != "B" || userChoice != "W" || userChoice != "R" || userChoice != "X");
        }

        public void CartOptions()
        {
            Console.WriteLine();
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                Console.WriteLine();
                if (userChoice == "C")
                {
                    CheckOut();
                    break;
                }
                else if (userChoice == "X")
                {
                    RemoveItem();
                    break;
                }
                else if (userChoice == "A")
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("[1]-Jordan | [2]-Nike | [3]-Adidas ");
                    Console.WriteLine("========================================= \n");
                    userChoice = GetUserChoice("Select an option: ");
                    if (userChoice == "1")
                    {
                        AllShoeJordan();
                        break;
                    }
                    else if (userChoice == "2")
                    {
                        AllShoeNike();
                        break;
                    }
                    else if (userChoice == "3")
                    {
                        AllShoeAdidas();
                        break;
                    }
                }
                else if (userChoice == "R")
                {
                    Menu();
                    break;
                }
                Console.WriteLine("Error: Please enter the letter in the box");
            } while (userChoice != "A" || userChoice != "C" || userChoice != "X");
        }
        //#endregion

        //#region Añadir mas objetos
        public void AddAnotherJordan()
        {
            Console.WriteLine();
            Console.Write("[A]-Add another item | ");
            Console.Write("[V]-View Shop Cart | ");
            Console.WriteLine("[R]-Return to previous page\n");
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                Console.WriteLine();
                if (userChoice == "A")
                {
                    AddJordanToCart();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "R")
                {
                    Catalog();
                    break;
                }
                Console.WriteLine("Error: Please enter the letter in the box");
            } while (userChoice != "A" || userChoice != "V" || userChoice != "R");
        }

        public void AddAnotherNike()
        {
            Console.WriteLine();
            Console.Write("[A]-Add another item | ");
            Console.Write("[V]-View Shop Cart | ");
            Console.WriteLine("[R]-Return to previous page\n");
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                Console.WriteLine();
                if (userChoice == "A")
                {
                    AddNikeToCart();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "R")
                {
                    Catalog();
                    break;
                }
                Console.WriteLine("Error: Please enter the letter in the box");
            } while (userChoice != "A" || userChoice != "V" || userChoice != "R");
        }

        public void AddAnotherAdidas()
        {
            Console.WriteLine();
            Console.Write("[A]-Add another item | ");
            Console.Write("[V]-View Shop Cart | ");
            Console.WriteLine("[R]-Return to previous page\n");
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                Console.WriteLine();
                if (userChoice == "A")
                {
                    AddAdidasToCart();
                    break;
                }
                else if (userChoice == "V")
                {
                    ShopCart();
                    break;
                }
                else if (userChoice == "R")
                {
                    Catalog();
                    break;
                }
                Console.WriteLine("Error: Please enter the letter in the box [A] [V] [R]");
            } while (userChoice != "A" || userChoice != "V" || userChoice != "R");
        }
        //#endregion

        //#region RemoveOption
        public void RemoveItem()
        {
            if (shopCart.Count > 0)
            {
                Console.WriteLine("Removing Item!");
                userNumberItem = GetNumberItem("Enter the number: ");
                for (int i = 0; i < shopCart.Count; i++)
                {
                    if (userNumberItem == shopCart.IndexOf(shopCart[i]) && userNumberItem == shopCartPrices.IndexOf(shopCartPrices[i]))
                    {
                        shopCart.Remove(shopCart[i]);
                        shopCartPrices.Remove(shopCartPrices[i]);
                    }
                    else
                    {
                        Console.WriteLine("I cant find this item");
                    }
                }
                ShopCart();
            }
            else
            {
                Console.WriteLine("No items for remove!");
                CartOptions();
            }
        }
        //#endregion

        //#region CheckOut
        //Opcion para pagar
        public void CheckOut()
        {
            if (userbudget >= orderTotal)
            {
                Console.WriteLine("Your balance:   \n$");    
                Console.WriteLine(userbudget - orderTotal );
                Console.WriteLine("Purchase Successful bro! \n");
                Console.WriteLine("=========================================");
                Console.WriteLine("[M]-Make another purchase | [E]-Exit");
                Console.WriteLine("========================================= \n");

                foreach (var item in shopCart)
                {
                    item.cartQuantity = 0;
                }

                shopCart.Clear();
                shopCartPrices.Clear();
                userbudget = userbudget - orderTotal;
                orderTotal = 0;
                CheckOutOptions();
            }
            else
            {
                Console.WriteLine("Decline ! \n");
                Console.WriteLine("=========================================");
                Console.WriteLine("[X]-Remove Item      |         [E]-Exit");
                Console.WriteLine("========================================= \n");
                CheckOutOptions();
            }
            //Cuando el jugador se quede sin dinero
            if (userbudget == 0)
            {
                Console.WriteLine("Decline! \n");
                Console.WriteLine("Budget is zero my friends");
                Console.WriteLine("=========================================");
                Console.WriteLine("[X]-Remove Item      |         [E]-Exit");
                Console.WriteLine("========================================= \n");
                CheckOutOptions();
            }
        }
        //Opciones del Checkout
        public void CheckOutOptions()
        {
            do
            {
                userChoice = GetUserChoice("Select an option: ");
                if (userChoice == "M")
                {
                    Catalog();
                    break;
                }
                else if (userChoice == "X")
                {
                    RemoveItem();
                    break;
                }
                else if (userChoice == "C")
                {
                    CheckOut();
                    break;
                }
                else if (userChoice == "E")
                {
                    ExitTheShop();
                    break;
                }
            } while (userChoice != "M" || userChoice != "E" || userChoice != "C");
        }
        //#endregion

        //#region ExitOption Region
        public void ExitTheShop()
        {
            Console.WriteLine("Are you sure you want to leaves [Y] or [N]");
            userChoice = Convert.ToString(Console.ReadLine().ToUpper());
            if (userChoice == "Y")
            {
               
               

            }
            else if(userChoice == "N")
            {
                Menu();
                return;
            }

           


            Console.WriteLine();
            Console.WriteLine("Your balance:" + "$" + userbudget);
            Console.WriteLine();
            Console.WriteLine("Thanks for visit Shoe shot!!");
            Console.WriteLine("Leaving the store....");
            Console.WriteLine("Press <ENTER> to leave");
            Console.WriteLine();
        }
        //#endregion

        //#region Select Region
        //Para seleccior la opcion
        public static string GetUserChoice(string prompt)
        {
            while (true)
            {
                try
                {
                   
                    Console.Write(prompt);
                    return Convert.ToString(Console.ReadLine().ToUpper());
                }
                catch
                { }
            }
        }

        private static double GetBudget()

        {

            double budget;

            do

            {

                Console.Clear();

                Console.Write("Dear customer, please enter your budget: $");

                _ = double.TryParse(Console.ReadLine(), out budget);



                if (  budget <= 500)

                {

                    Console.WriteLine("Enter a valid budget, please press anykey to continue");

                    Console.ReadKey(true);

                }

            } while (budget <= 500);



            return budget;

        }
        //Para seleccionar el # o la cantidad
        public static int GetNumberItem(string prompt)
        {
            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                }
            }
        }

        //#endregion
    }
}
