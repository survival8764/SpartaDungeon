// using System;
// using System.Collections.Generic;

// public interface IScreen
// {
//     void Introduce();
//     void Menu();
//     void Input();
//     void Window();
// } 

// public class MainScreen : IScreen
// {
//     bool isNumberGuessed;

//     public MainScreen()
//     {
//         this.isNumberGuessed = false;
//     }

//     public void Window()
//     {
//         Introduce();
//         Menu();
//         Input();
//     }

//     public void Introduce()
//     {
//         Console.WriteLine();
//         Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
//         Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
//         Console.WriteLine();
//     }
//     public void Menu()
//     {
//         Console.WriteLine("1. 상태보기");
//         Console.WriteLine("2. 인벤토리");
//         Console.WriteLine("3. 상점");
//         Console.WriteLine();
//     }
//     public void Input()
//     {
//         while(!isNumberGuessed)
//         {
//             Console.WriteLine("원하시는 행동을 입력해주세요.");
//             Console.Write(">>");

//             string userInput = Console.ReadLine();
//             int userGuess;

//             if (int.TryParse(userInput, out userGuess))
//             {
//                 if(userGuess == 1)
//                 {
//                     Console.Clear();
//                     //statusScreen = new StatusScreen();
//                     isNumberGuessed = true;
//                 }
//                 else if(userGuess == 2)
//                 {
//                     Console.Clear();
//                     InventoryScreen inventoryScreen = new InventoryScreen();
//                     isNumberGuessed = true;
//                 }
//                 else if(userGuess == 3)
//                 {
//                     Console.Clear();
//                     StoreScreen storeScreen = new StoreScreen();
//                     isNumberGuessed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("잘못된 입력입니다.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("잘못된 입력입니다.");
//             }
//         }
//     }

// }

// public class StatusScreen : IScreen
// {
//     bool isNumberGuessed;

//     public StatusScreen()
//     {
//         this.isNumberGuessed = false;
//     }

//     public void Window()
//     {
//         Introduce();
//         Menu();
//         Input();
//     }
//     public void Introduce()
//     {
//         Console.WriteLine();
//         Console.WriteLine("상태보기");
//         Console.WriteLine("캐릭터의 정보가 표시됩니다.");
//         Console.WriteLine();
//     }
//     public void Menu()
//     {
//         Console.WriteLine("0. 나가기");
//         Console.WriteLine();
//     }
//     public void Input()
//     {
//         while(!isNumberGuessed)
//         {
//             Console.WriteLine("원하시는 행동을 입력해주세요.");
//             Console.Write(">>");

//             string userInput = Console.ReadLine();
//             int userGuess;

//             if (int.TryParse(userInput, out userGuess))
//             {
//                 if(userGuess == 0)
//                 {
//                     Console.Clear();
//                     MainScreen mainScreen = new MainScreen();
//                     isNumberGuessed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("잘못된 입력입니다.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("잘못된 입력입니다.");
//             }
//         }
//     }

// }

// public class InventoryScreen : IScreen
// {
//     bool isNumberGuessed;

//     public InventoryScreen()
//     {
//         this.isNumberGuessed = false;
//     }

//     public void Window()
//     {
//         Introduce();
//         Menu();
//         Input();
//     }
//     public void Introduce()
//     {
//         Console.WriteLine();
//         Console.WriteLine("인벤토리");
//         Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
//         Console.WriteLine();
//     }
//     public void Menu()
//     {
//         Console.WriteLine("1. 장착 관리");
//         Console.WriteLine("0. 나가기");
//         Console.WriteLine();
//     }
//     public void Input()
//     {
//         while(!isNumberGuessed)
//         {
//             Console.WriteLine("원하시는 행동을 입력해주세요.");
//             Console.Write(">>");

//             string userInput = Console.ReadLine();
//             int userGuess;

//             if (int.TryParse(userInput, out userGuess))
//             {
//                 if(userGuess == 1)
//                 {
//                     Console.Clear();
//                     EquipInvenScreen equipInvenScreen = new EquipInvenScreen();
//                     isNumberGuessed = true;
//                 }
//                 else if(userGuess == 0)
//                 {
//                     Console.Clear();
//                     MainScreen mainScreen = new MainScreen();
//                     isNumberGuessed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("잘못된 입력입니다.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("잘못된 입력입니다.");
//             }
//         }
//     }

// }

// public class EquipInvenScreen : IScreen
// {
//     bool isNumberGuessed;

//     public EquipInvenScreen()
//     {
//         this.isNumberGuessed = false;
//     }
//     public void Window()
//     {
//         Introduce();
//         Menu();
//         Input();
//     }
//     public void Introduce()
//     {
//         Console.WriteLine();
//         Console.WriteLine("인벤토리 - 장착 관리");
//         Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
//         Console.WriteLine();
//     }
//     public void Menu()
//     {
//         Console.WriteLine("0. 나가기");
//         Console.WriteLine();
//     }
//     public void Input()
//     {
//         while(!isNumberGuessed)
//         {
//             Console.WriteLine("원하시는 행동을 입력해주세요.");
//             Console.Write(">>");

//             string userInput = Console.ReadLine();
//             int userGuess;

//             if (int.TryParse(userInput, out userGuess))
//             {
//                 if(userGuess == 0)
//                 {
//                     Console.Clear();
//                     InventoryScreen inventoryScreen = new InventoryScreen();
//                     isNumberGuessed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("잘못된 입력입니다.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("잘못된 입력입니다.");
//             }
//         }
//     }

// }

// public class StoreScreen : IScreen
// {
//     bool isNumberGuessed;

//     public StoreScreen()
//     {
//         this.isNumberGuessed = false;
//     }

//     public void Window()
//     {
//         Introduce();
//         Menu();
//         Input();
//     }
//     public void Introduce()
//     {
//         Console.WriteLine();
//         Console.WriteLine("상점");
//         Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
//         Console.WriteLine();
//     }
//     public void Menu()
//     {
//         Console.WriteLine("1. 아이템 구매");
//         Console.WriteLine("0. 나가기");
//         Console.WriteLine();
//     }
//     public void Input()
//     {
//         while(!isNumberGuessed)
//         {
//             Console.WriteLine("원하시는 행동을 입력해주세요.");
//             Console.Write(">>");

//             string userInput = Console.ReadLine();
//             int userGuess;

//             if (int.TryParse(userInput, out userGuess))
//             {
//                 if(userGuess == 1)
//                 {
//                     Console.Clear();
//                     BuyScreen buyScreen = new BuyScreen();
//                     isNumberGuessed = true;
//                 }
//                 else if(userGuess == 0)
//                 {
//                     Console.Clear();
//                     MainScreen mainScreen = new MainScreen();
//                     isNumberGuessed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("잘못된 입력입니다.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("잘못된 입력입니다.");
//             }
//         }
//     }

// }

// public class BuyScreen : IScreen
// {
//     bool isNumberGuessed;

//     public BuyScreen()
//     {
//         this.isNumberGuessed = false;
//     }

//     public void Window()
//     {
//         Introduce();
//         Menu();
//         Input();
//     }
//     public void Introduce()
//     {
//         Console.WriteLine();
//         Console.WriteLine("상점 - 아이템 구매");
//         Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
//         Console.WriteLine();
//     }
//     public void Menu()
//     {
//         Console.WriteLine("0. 나가기");
//         Console.WriteLine();
//     }
//     public void Input()
//     {
//         while(!isNumberGuessed)
//         {
//             Console.WriteLine("원하시는 행동을 입력해주세요.");
//             Console.Write(">>");

//             string userInput = Console.ReadLine();
//             int userGuess;

//             if (int.TryParse(userInput, out userGuess))
//             {
//                 if(userGuess == 0)
//                 {
//                     Console.Clear();
//                     StoreScreen storeScreen = new StoreScreen();
//                     isNumberGuessed = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("잘못된 입력입니다.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("잘못된 입력입니다.");
//             }
//         }
//     }

// }

// // class SpartaDungeon
// // {
    
// //     static void Main(string[] args)
// //     {
// //         MainScreen mainScreen = new MainScreen();
// //         StatusScreen statusScreen = new StatusScreen();
// //         InventoryScreen inventoryScreen = new InventoryScreen();
// //         EquipInvenScreen equipInvenScreen = new EquipInvenScreen();
        
        

// //         Console.ReadLine();
// //     }
// // }