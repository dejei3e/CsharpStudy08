using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 맹효주.수업내용; 

/*
 * using : 이름 공간을 사용해라 
 * using 이름공간.이름공간; 
 * -> 네임 스페이스를 그 공간 안에 있는 코드를 사용할 수 있다. 
 */

namespace 맹효주
{
    namespace 수업내용
    {
        /*
         *클래스
         *사용자 정의 데이터 유형. -> int, flout, string, char
         *클래스를 이용하여 객체를 생성하고 그 객체 내부에 있는 변수와 메소드를 이용하여 데이터에 접근하고 사용할 수 있는 집합체.
         */

        /*
         * 1. 클래스의 선언
         * class 이름 {  } 
         *
         */

        // 슬라임 

        

        class Monster
        {
            // 공격한다 (행동) 

            // 체력 
            // 공격력 
            // 방어력 
        }

        /*
        * 1. 클래스의 사용
        */


    }
}

namespace 메이플스토리
{

    class Player
    {
        public int HP;
        public int AttakPower;
        public string Name;
        public float MoveSpeed;

        public void Show()
        {

            Console.WriteLine($"{Name}의 체력: {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttakPower}");
            Console.WriteLine($"{Name}의 속도 : {MoveSpeed}");
        }

        public void Attack(Slime slime)
        {
            slime.HP = slime.HP - AttakPower;

            Console.WriteLine($"플레이어가 {slime.Name}을 공격했습니다!");
            Console.WriteLine($"-----------결과------------");
            Console.WriteLine($"{Name}의 체력 : {MoveSpeed}");


        }

        public void Rest()
        {
           
            HP = HP + 10;

            Console.WriteLine($"플레이어가 휴식을 했습니다!");
            Console.WriteLine($"------------------결과-------------------");
            Console.WriteLine($"플레이어의 체력을 회복했습니다!");
            Console.WriteLine($"플레이어의 현재 체력 : {HP}");

        }

        public void Suicide()
        {
            HP = HP - 13;

            Console.WriteLine($"플레이어가 자폭을 선택했습니다!");
            Console.WriteLine($"------------------결과-------------------");
            Console.WriteLine($"플레이어의 현재 체력 : {HP}");

        }
    }

    class Slime
    {
        // 슬라임의 체력은 50입니다. 실수형, 정수형 

        /*
         * 접근 지정자 
         * 1. public : 공공의, 외부에서 전부 사용할 수 있게 하라 
         * 2. private : class 내부에서만 사용해라, 접근 지정자를 명시하지 않으면 자동으로 private 선언이 된다 
         */

        public int HP;
        public int AttakPower;
        public string Name;
        public float MoveSpeed;


        /*
         * 메소드 : 코드를 하나의 이름 아래 묶는 것.
         * 묶인 코드를 이름을 불러주는 것만으로 실행할 수 있다. 
         * 메소드를 호출하는 것을 Call metod (메소드 호출)
         */

        /*
         * (접근지정자) + (반환값) + (메소드의 이름)  + () + ()
         * public           void      Show ()        {묶인 코드 내용물 } 
         * 접근지정자 : private, public - > public 선언을 해주세요 
         * 반환값이 없는 경우 : void
         * 반환값이 있는 겨우 : int, Float, String, Class이름 반환하라
         * 메소드의 이름 : 
         */

        int REturnHp()
        {
            //반환값이 있는 함수인 경우에는 return + 변수의 이름 + => 해당하는 변수 값을 변환한다. 
            return HP; 
        }

        string ReturnName()
        {
            return Name; 
        }

        float FeturnMoveSpeed()
        {
            return MoveSpeed; 
        }

        //슬라임이 공격하는 메소드를 만들어보세요
        //슬라임이 공격할 대상이 필요합니다
        public void Beattacked(int damaged)
        {
            //슬라임의 체력 - 플레이어의 공격력 
            HP = HP;
        }

        public void Attack(Player player)
        {
            // 플레이어의 체력을 슬라임의 공격으로 깍는다.
            player.HP = player.HP - AttakPower;
        }

        public void Show()
        {

            Console.WriteLine($"{Name}의 체력: {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttakPower}");
            Console.WriteLine($"{Name}의 속도 : {MoveSpeed}");
        }

    }
    class 달팽이
    {
     public int HP;
     public int AttakPower;
     public string Name;
     public float MoveSpeed;

        public void Show()
        {

            Console.WriteLine($"{Name}의 체력: {HP}");
            Console.WriteLine($"{Name}의 공격력 : {AttakPower}");
            Console.WriteLine($"{Name}의 속도 : {MoveSpeed}");
        }
    }

}

namespace 클래스와_메소드
{
    internal class 클래스
    {

    }
}
