using System;
using System.Collections.Generic;

public enum WINDOWTYPE
{
    START,
    STATUS,
    INVENTORY,
    EQUIPINVENTORY,
    STORE,
    BUYSTORE,
    SELLSTORE,
    DUNGEON,
    DUNGEONCREAR,
    REST
}
public enum DUNGEON
{
    EASY,
    NORMAL,
    HARD
}

public class Status
{
    public int level;
    public String name;
    public String job;
    public int offense;
    public int defense;
    public int health;
    public int gold;
    public int offenseUp;
    public int defenseUp;
    
    public Status(int _level, string _name, String _job, int _offense, int _defense, int _health, int _gold)
    {
        level = _level;
        name = _name;
        job = _job;
        offense = _offense;
        defense = _defense;
        health = _health;
        gold = _gold;
        offenseUp = 0;
        defenseUp = 0;
    }

    public void StatusView()
    {
        Console.WriteLine("LV. {0}", level);
        Console.WriteLine("{0} ( {1} )", name, job);
        if(offenseUp > 0)
        {
            Console.WriteLine("공격력 : {0} (+{1})", offense, offenseUp);
        }
        else
        {
            Console.WriteLine("공격력 : {0}", offense);
        }
        
        if(defenseUp > 0)
        {
            Console.WriteLine("방어력 : {0} (+{1})", defense, defenseUp);
        }
        else
        {
            Console.WriteLine("방어력 : {0}", defense);
        }
        Console.WriteLine("체 력 : {0}", health);
        Console.WriteLine("Gold : {0} G", gold);
    }
    public void StatusControl(int _offenseUp, int _defenseUp, String _useYn)
    {
        if("Y".Equals(_useYn))
        {
            offenseUp += _offenseUp;
            defenseUp += _defenseUp;
            offense += _offenseUp;
            defense += _defenseUp;
        }
        else if("N".Equals(_useYn))
        {
            offenseUp -= _offenseUp;
            defenseUp -= _defenseUp;
            offense -= _offenseUp;
            defense -= _defenseUp;
        }
    }
}

public class Inventory
{
    public Item[] itemArr;

    public int maxLength;

    public int useSpace;

    public Inventory()
    {
        maxLength = 40;
        useSpace = 0;

        itemArr = new Item[maxLength];

        // Item item1 = new Item("armor", "무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 5, "Y", 2000);
        // Item item2 = new Item("spear", "스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 7, 0, "N", 3000);
        // Item item3 = new Item("sword", "낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 2, 0, "N", 600);
        
        // itemArr[0] = item1;
        // itemArr[1] = item2;
        // itemArr[2] = item3;

        // useSpace += 3;
    }

    public void InventoryView()
    {

        Console.WriteLine("[아이템 목록]");
        for(int i = 0 ; i < useSpace ; i++)
        {   
            if("sword".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- [E]{0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation);
                }
            }
            else if("spear".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- [E]{0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation);
                }
            }
            else if("armor".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- [E]{0} | 방어력 +{1} | {2}", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 방어력 +{1} | {2}", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation);
                }
            }
        }

    }

    public void EquipInventoryView()
    {
        Console.WriteLine("[아이템 목록]");
        for(int i = 0 ; i < useSpace ; i++)
        {   
            if("sword".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} [E]{0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} {0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, i+1);
                }
            }
            else if("spear".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} [E]{0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} {0} | 공격력 +{1} | {2}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, i+1);
                }
            }
            else if("armor".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} [E]{0} | 방어력 +{1} | {2}", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} {0} | 방어력 +{1} | {2}", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, i+1);
                }
            }
        }

    }

    public void SellInventoryView()
    {

        Console.WriteLine("[아이템 목록]");
        for(int i = 0 ; i < useSpace ; i++)
        {   
            if("sword".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} [E]{0} | 공격력 +{1} | {2} | {3} G", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price * 0.85, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} {0} | 공격력 +{1} | {2} | {3} G", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price * 0.85, i+1);
                }
            }
            else if("spear".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} [E]{0} | 공격력 +{1} | {2} | {3} G", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price * 0.85, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} {0} | 공격력 +{1} | {2} | {3} G", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price * 0.85, i+1);
                }
            }
            else if("armor".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} [E]{0} | 방어력 +{1} | {2} | {3} G", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, itemArr[i].price * 0.85, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} {0} | 방어력 +{1} | {2} | {3} G", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, itemArr[i].price * 0.85, i+1);
                }
            }
        }

    }

}

public class StoreInventory
{
    public Item[] itemArr;

    public int maxLength;

    public int useSpace;

    public StoreInventory()
    {
        maxLength = 100;
        useSpace = 0;

        itemArr = new Item[maxLength];

        Item item1 = new Item("armor", "수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", 0, 5, "N", 1000);
        Item item2 = new Item("armor", "무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 9, "N", 2000);
        Item item3 = new Item("armor", "스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 0, 15, "N", 3000);
        Item item4 = new Item("sword", "낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 2, 0, "N", 600);
        Item item5 = new Item("spear", "청동 도끼", "어디선가 사용했던거 같은 도끼입니다.", 5, 0, "N", 1500);
        Item item6 = new Item("spear", "스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 7, 0, "N", 3000);
        
        itemArr[0] = item1;
        itemArr[1] = item2;
        itemArr[2] = item3;
        itemArr[3] = item4;
        itemArr[4] = item5;
        itemArr[5] = item6;

        useSpace += 6;
    }

    public void InventoryView()
    {

        Console.WriteLine("[아이템 목록]");
        for(int i = 0 ; i < useSpace ; i++)
        {   
            if("sword".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 공격력 +{1} | {2} | 구매완료", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 공격력 +{1} | {2} | {3}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price);
                }
            }
            else if("spear".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 공격력 +{1} | {2} | 구매완료", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 공격력 +{1} | {2} | {3}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price);
                }
            }
            else if("armor".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 방어력 +{1} | {2} | 구매완료", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {0} | 방어력 +{1} | {2} | {3}", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, itemArr[i].price);
                }
            }
        }

    }
    public void StoreInventoryView()
    {

        Console.WriteLine("[아이템 목록]");
        for(int i = 0 ; i < useSpace ; i++)
        {   
            if("sword".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} {0} | 공격력 +{1} | {2} | 구매완료", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} {0} | 공격력 +{1} | {2} | {3}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price, i+1);
                }
            }
            else if("spear".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} {0} | 공격력 +{1} | {2} | 구매완료", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} {0} | 공격력 +{1} | {2} | {3}", itemArr[i].name, itemArr[i].offenseUp, itemArr[i].explanation, itemArr[i].price, i+1);
                }
            }
            else if("armor".Equals(itemArr[i].type))
            {
                if("Y".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {3} {0} | 방어력 +{1} | {2} | 구매완료", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, i+1);
                }
                else if("N".Equals(itemArr[i].useYn))
                {
                    Console.WriteLine("- {4} {0} | 방어력 +{1} | {2} | {3}", itemArr[i].name, itemArr[i].defenseUp, itemArr[i].explanation, itemArr[i].price, i+1);
                }
            }
        }

    }
    
}

public struct Item
{
    public String type;
    public String name;
    public String explanation;
    public int offenseUp;
    public int defenseUp;
    public String useYn;
    public int price;
    public Item(String _type, String _name, String _explanation, int _offenseUp, int _defenseUp, String _useYn, int _price)
    {
        type = _type;
        name = _name;
        explanation = _explanation;
        offenseUp = _offenseUp;
        defenseUp = _defenseUp;
        useYn = _useYn;
        price = _price;
    }
}

public class Screen
{
    WINDOWTYPE window;
    Player player;
    Store store;
    Dungeon dungeon;
    Rest rest;
    Status status;

    public Screen(WINDOWTYPE _window, Player _player, Store _store, Dungeon _dungeon, Rest _rest)
    {
        window = _window;
        player = _player;
        store = _store;
        dungeon = _dungeon;
        rest = _rest;
    }

    public void Show()
    {   
        Console.Clear();
        Introduce();
        stateView();
        Menu();
        Input();
    }
    public void Introduce()
    {
        switch (window)
        {
            case WINDOWTYPE.START:
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                break;
            case WINDOWTYPE.STATUS:
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                break;
            case WINDOWTYPE.INVENTORY:
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                break;
            case WINDOWTYPE.EQUIPINVENTORY:
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                break;
            case WINDOWTYPE.STORE:
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                break;
            case WINDOWTYPE.BUYSTORE:
                Console.WriteLine("상점 - 아이템 구매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                break;
            case WINDOWTYPE.SELLSTORE:
                Console.WriteLine("상점 - 아이템 판매");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                break;
            case WINDOWTYPE.DUNGEON:
                Console.WriteLine("던전입장");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                break;
            case WINDOWTYPE.DUNGEONCREAR:
                dungeon.DungeonBattle();
                if(dungeon.clearYn == "Y")
                {
                    Console.WriteLine("던전 클리어");
                    Console.WriteLine("축하합니다!");
                    switch (dungeon.level)
                    {
                    case DUNGEON.EASY:
                        Console.WriteLine("쉬운 던전을 클리어 하였습니다.");
                        break;
                    case DUNGEON.NORMAL:
                        Console.WriteLine("일반 던전을 클리어 하였습니다.");
                        break;
                    case DUNGEON.HARD:
                        Console.WriteLine("어려운 던전을 클리어 하였습니다.");
                        break;
                    }
                }
                else if(dungeon.clearYn == "N")
                {
                    Console.WriteLine("던전 클리어 실패");
                    Console.WriteLine("빈사상태가 되었습니다.");
                }
                break;
            case WINDOWTYPE.REST:
                status = player.ConfirmStatus();
                Console.WriteLine("휴식하기");
                Console.WriteLine("500 G 를 내면 체력을 회복할 수 있습니다. (보유 골드 : {0} G)", status.gold);
                break;
        }

        Console.WriteLine();
    }
    public void Menu()
    {
        Console.WriteLine();

        switch (window)
        {
            case WINDOWTYPE.START:
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 던전입장");
                Console.WriteLine("5. 휴식하기");
                break;
            case WINDOWTYPE.STATUS:
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.INVENTORY:
                Console.WriteLine("1. 장착관리");
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.EQUIPINVENTORY:
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.STORE:
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("2. 아이템 판매");
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.BUYSTORE:
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.SELLSTORE:
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.DUNGEON:
                Console.WriteLine("1. 쉬운 던전 | 방어력 5 이상 권장");
                Console.WriteLine("2. 일반 던전 | 방어력 11 이상 권장");
                Console.WriteLine("3. 어려운 던전 | 방어력 17 이상 권장");
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.DUNGEONCREAR:
                Console.WriteLine("0. 나가기");
                break;
            case WINDOWTYPE.REST:
                Console.WriteLine("1. 휴식하기");
                Console.WriteLine("0. 나가기");
                break;
        }

        Console.WriteLine();
    }

    public void Input()
    {
        bool isNumberGuessed = false;

        while(!isNumberGuessed)
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");

            string userInput = Console.ReadLine();
            int userGuess;

            if (int.TryParse(userInput, out userGuess))
            {
                switch (window)
                {
                    case WINDOWTYPE.START:
                        if(userGuess == 1)
                        {
                            window = WINDOWTYPE.STATUS;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 2)
                        {
                            window = WINDOWTYPE.INVENTORY;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 3)
                        {
                            window = WINDOWTYPE.STORE;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 4)
                        {
                            window = WINDOWTYPE.DUNGEON;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 5)
                        {
                            window = WINDOWTYPE.REST;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                    case WINDOWTYPE.STATUS:
                        if(userGuess == 0)
                        {
                            window = WINDOWTYPE.START;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                    case WINDOWTYPE.INVENTORY:
                        if(userGuess == 1)
                        {
                            window = WINDOWTYPE.EQUIPINVENTORY;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 0)
                        {
                            window = WINDOWTYPE.START;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                    case WINDOWTYPE.EQUIPINVENTORY:
                        isNumberGuessed = player.UseItem(userGuess);
                        if(userGuess == 0)
                        {
                            window = WINDOWTYPE.INVENTORY;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            if(!isNumberGuessed)
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }
                        }
                        break;
                    case WINDOWTYPE.STORE:
                        if(userGuess == 1)
                        {
                            window = WINDOWTYPE.BUYSTORE;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 2)
                        {
                            window = WINDOWTYPE.SELLSTORE;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 0)
                        {
                            window = WINDOWTYPE.START;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                    case WINDOWTYPE.BUYSTORE:
                        isNumberGuessed = store.BuyItem(userGuess, player);
                        if(userGuess == 0)
                        {
                            window = WINDOWTYPE.STORE;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            if(!isNumberGuessed)
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }
                        }
                        break;
                    case WINDOWTYPE.SELLSTORE:
                        isNumberGuessed = store.SellItem(userGuess, player);
                        if(userGuess == 0)
                        {
                            window = WINDOWTYPE.STORE;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            if(!isNumberGuessed)
                            {
                                Console.WriteLine("잘못된 입력입니다.");
                            }
                        }
                        break;
                    case WINDOWTYPE.DUNGEON:
                        if(userGuess == 1)
                        {
                            window = WINDOWTYPE.DUNGEONCREAR;
                            dungeon.level = DUNGEON.EASY;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 2)
                        {
                            window = WINDOWTYPE.DUNGEONCREAR;
                            dungeon.level = DUNGEON.NORMAL;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 3)
                        {
                            window = WINDOWTYPE.DUNGEONCREAR;
                            dungeon.level = DUNGEON.HARD;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 0)
                        {
                            window = WINDOWTYPE.START;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                    case WINDOWTYPE.DUNGEONCREAR:
                        if(userGuess == 0)
                        {
                            window = WINDOWTYPE.START;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                    case WINDOWTYPE.REST:
                        if(userGuess == 1)
                        {   
                            rest.Recovery();
                            window = WINDOWTYPE.REST;
                            isNumberGuessed = true;
                        }
                        else if(userGuess == 0)
                        {
                            window = WINDOWTYPE.START;
                            isNumberGuessed = true;
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }

    public void stateView()
    {
        switch (window)
        {
            case WINDOWTYPE.START:
                break;
            case WINDOWTYPE.STATUS:
                player.StatusShow();
                break;
            case WINDOWTYPE.INVENTORY:
                player.InventoryShow();
                break;
            case WINDOWTYPE.EQUIPINVENTORY:
                player.EquipInventoryShow();
                break;
            case WINDOWTYPE.STORE:
                player.CheckCash();
                store.InventoryShow();
                break;
            case WINDOWTYPE.BUYSTORE:
                player.CheckCash();
                store.StoreInventoryShow();
                break;
            case WINDOWTYPE.SELLSTORE:
                player.CheckCash();
                player.SellInventoryShow();
                break;
            case WINDOWTYPE.DUNGEON:
                break;
            case WINDOWTYPE.DUNGEONCREAR:
                dungeon.DungeonClear();
                break;
            case WINDOWTYPE.REST:
                break;
        }
    }
}

public class Player
{
    Status status;

    Inventory inventory;

    public Player(Status _status, Inventory _inventory)
    {
        status = _status;
        inventory = _inventory;
    }

    public void StatusShow()
    {
        status.StatusView();
    }
    public void InventoryShow()
    {
        inventory.InventoryView();
    }
    public void EquipInventoryShow()
    {
        inventory.EquipInventoryView();
    }
    public void SellInventoryShow()
    {
        inventory.SellInventoryView();
    }
    public bool UseItem(int _userGuess)
    {
        bool isNumberGuessed = false;

        for(int i = 0 ; i < inventory.useSpace ; i++)
        {
            if(i+1 == _userGuess)
            {
                for(int j = 0 ; j < inventory.useSpace ; j++)
                {
                    if(inventory.itemArr[i].type == inventory.itemArr[j].type && inventory.itemArr[j].useYn == "Y" && i != j)
                    {
                        inventory.itemArr[j].useYn = "N";
                        status.StatusControl(inventory.itemArr[j].offenseUp, inventory.itemArr[j].defenseUp, inventory.itemArr[j].useYn);
                    }
                }

                if("Y".Equals(inventory.itemArr[i].useYn))
                {
                    inventory.itemArr[i].useYn = "N";
                    status.StatusControl(inventory.itemArr[i].offenseUp, inventory.itemArr[i].defenseUp, inventory.itemArr[i].useYn);
                    isNumberGuessed = true;
                }
                else if("N".Equals(inventory.itemArr[i].useYn))
                {
                    inventory.itemArr[i].useYn = "Y";
                    status.StatusControl(inventory.itemArr[i].offenseUp, inventory.itemArr[i].defenseUp, inventory.itemArr[i].useYn);
                    isNumberGuessed = true;
                }
            }
        }
        
        return isNumberGuessed;
    }
    public void CheckCash()
    {
        Console.WriteLine();
        Console.WriteLine("[보유골드]");
        Console.WriteLine("{0} G", status.gold);
        Console.WriteLine();
    }
    public Status ConfirmStatus()
    {
        return status;
    }
    public Inventory ConfirmInventory()
    {
        return inventory;
    }

}

public class Store
{
    StoreInventory storeInventory;
    public Store(StoreInventory _storeInventory)
    {
        storeInventory = _storeInventory;
    }

    public void InventoryShow()
    {
        storeInventory.InventoryView();
    }
    public void StoreInventoryShow()
    {
        storeInventory.StoreInventoryView();
    }
    public bool BuyItem(int _userGuess, Player _player)
    {
        bool isNumberGuessed = false;
        Status status = _player.ConfirmStatus();
        Inventory inventory = _player.ConfirmInventory();

        for(int i = 0 ; i < storeInventory.useSpace ; i++)
        {
            if(i+1 == _userGuess)
            {
                if("N".Equals(storeInventory.itemArr[i].useYn))
                {
                    if(status.gold >= storeInventory.itemArr[i].price)
                    {   
                        Item buyItem = new Item(storeInventory.itemArr[i].type, 
                                                storeInventory.itemArr[i].name,
                                                storeInventory.itemArr[i].explanation,
                                                storeInventory.itemArr[i].offenseUp,
                                                storeInventory.itemArr[i].defenseUp,
                                                "N",
                                                storeInventory.itemArr[i].price);
                        
                        inventory.itemArr[inventory.useSpace] = buyItem;
                        inventory.useSpace += 1;
                        status.gold -= storeInventory.itemArr[i].price;
                        storeInventory.itemArr[i].useYn = "Y";
                        isNumberGuessed = true;
                        Console.WriteLine("{0} 를(을) 구매하셨습니다.", storeInventory.itemArr[i].name);
                        Thread.Sleep(800);
                    }
                    else if(status.gold < storeInventory.itemArr[i].price)
                    {
                        Console.WriteLine("Gold 가 부족합니다.");
                    }
                }
                else if("Y".Equals(storeInventory.itemArr[i].useYn))
                {
                    Console.WriteLine("이미 구매한 아이템입니다.");
                }
            }
        }
        
        return isNumberGuessed;
    }

    public bool SellItem(int _userGuess, Player _player)
    {
        bool isNumberGuessed = false;
        Status status = _player.ConfirmStatus();
        Inventory inventory = _player.ConfirmInventory();

        for(int i = 0 ; i < inventory.useSpace ; i++)
        {
            if(i+1 == _userGuess)
            {
                inventory.useSpace -= 1;
                status.gold += Convert.ToInt32(((double)inventory.itemArr[i].price*0.85));
                Console.WriteLine("{0} 를(을) 판매하셨습니다.", inventory.itemArr[i].name);

                for(int j = i ; j < inventory.useSpace ; j++)
                {
                    inventory.itemArr[j] = inventory.itemArr[j+1];
                }
                
                isNumberGuessed = true;
                Thread.Sleep(800);
            }
        }

        return isNumberGuessed;
    }

}

public class Dungeon
{
    public DUNGEON level;
    public Player player;
    public Status status;
    public String clearYn;
    public int recommendDefense;
    public int reward;
    public int damage;
    public Dungeon(Player _player)
    {
        player = _player;
        clearYn = "N";
    }

    public void DungeonBattle()
    {
        status = player.ConfirmStatus();
        Random random = new Random();
        damage = random.Next(20, 36);

        switch (level)
        {
            case DUNGEON.EASY:
                recommendDefense = 5;
                reward = 1000;
                break;
            case DUNGEON.NORMAL:
                recommendDefense = 11;
                reward = 1700;
                break;
            case DUNGEON.HARD:
                recommendDefense = 17;
                reward = 2500;
                break;
        }

        damage += status.defense - recommendDefense;
        reward += random.Next(status.offense, status.offense*2+1);
        clearYn = "Y";

        if(status.defense < recommendDefense)
        {
            int percentage = random.Next(0, 100);

            if(percentage > 60)
            {
                clearYn = "N";
                damage = status.health/2;
                reward = 0;
            }
            else
            {
                clearYn = "Y";
            }
        }

    }

    public void DungeonClear()
    {
        status.level += 1;
        status.offense += 1;
        status.defense += 1;

        if(clearYn == "N")
        {
            status.level -= 1;
            status.offense -= 1;
            status.defense -= 1;
        }
        
        Console.WriteLine("[탐험 결과]");
        Console.WriteLine("체력 : {0} -> {1}", status.health, status.health - damage);
        Console.WriteLine("Gold : {0} G -> {1} G", status.gold, status.gold + reward);

        status.health -= damage;
        status.gold += reward;
    }
}

public class Rest
{
    Player player;
    Status status;
    int price;
    public Rest(Player _player)
    {
        player = _player;
        price = 500;
    }

    public void Recovery()
    {
        status = player.ConfirmStatus();

        if(status.gold >= price)
        {
            Console.WriteLine("휴식을 완료했습니다.");
            status.gold -= price;
            status.health = 100;
            Thread.Sleep(800);
        }
        else if(status.gold < price)
        {
            Console.WriteLine("Gold 가 부족합니다.");
            Thread.Sleep(800);
        }
    }
}


class SpartaDungeon2
{
    static void Main(string[] args)
    {
        WINDOWTYPE window = WINDOWTYPE.START;

        Status status = new Status(1, "chad", "전사", 10, 5, 100, 10000);

        Inventory inventory = new Inventory();

        Player player = new Player(status, inventory);

        StoreInventory storeInventory = new StoreInventory();

        Store store = new Store(storeInventory);

        Dungeon dungeon = new Dungeon(player);

        Rest rest = new Rest(player);

        Screen screen = new Screen(window, player, store, dungeon, rest);
        
        while(true)
        {
            switch (window)
            {
                case WINDOWTYPE.START:
                    screen.Show();
                    break;
                case WINDOWTYPE.STATUS:
                    screen.Show();
                    break;
                case WINDOWTYPE.INVENTORY:
                    screen.Show();
                    break;
                case WINDOWTYPE.EQUIPINVENTORY:
                    screen.Show();
                    break;
                case WINDOWTYPE.STORE:
                    screen.Show();
                    break;
                case WINDOWTYPE.BUYSTORE:
                    screen.Show();
                    break;
                case WINDOWTYPE.SELLSTORE:
                    screen.Show();
                    break;
                case WINDOWTYPE.DUNGEON:
                    screen.Show();
                    break;
                case WINDOWTYPE.DUNGEONCREAR:
                    screen.Show();
                    break;
                case WINDOWTYPE.REST:
                    screen.Show();
                    break;
            }
        }
        
        Console.ReadLine();
    }

}