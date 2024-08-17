using System.Security;
using System.Xml.Linq;
using 맹효주.수업내용;
using 메이플스토리;

namespace 클래스와_메소드
{
    internal class Program
    {
        static void PlayerTurn(Player player, Slime slime)
        {
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 휴식한다.");
            Console.WriteLine("3. 자폭한다.");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                player.Attack(slime);
            }
            else if (userInput == 2)
            {
                player.Rest();
            }
            else if (userInput == 3)
            {

            }
        }

        static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.Show();

            /*
             * 클래스 사용하는 방법
             * (이름공간.Slime) (클래스의 이름 변수) = new 메이플스토리.SLime(); 
             * 
             */

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.HP = 10;
            slime.AttakPower = 1;
            slime.MoveSpeed = 2.3f;
            slime.Show();

            메이플스토리.달팽이 monster1 = new 메이플스토리.달팽이();
            monster1.Name = "달팽이";
            monster1.HP = 40;
            monster1.AttakPower = 10;
            monster1.MoveSpeed = 1.3f;
            monster1.Show();

            메이플스토리.Player player = new 메이플스토리.Player();
            player.Name = "플레이어";
            player.HP = 100;
            player.AttakPower = 10;
            player.MoveSpeed = 1.0f;
            player.Show();
            player.Suicide(); 

            slime.Attack(player);
            slime.Beattacked(player.AttakPower);
            slime.Show(); 

            //Player.Show(); 

            while(true) // 무한 반복문 
            {

                PlayerTurn(player, slime); //함수로 코드를 정리해서, 코드로 쓰임새를 쉽게 정리할 수 있다. 

                slime.Attack(player); 
                player.Show();
                slime.Show();

                if(slime.HP <= 0)
                {
                    Console.WriteLine($"슬라임을 처치했습니다. 게임에서 승리했습니다.");
                    break; 
                }

                if(player.HP <= 0)
                {
                    Console.WriteLine($"플레이어가 사망했습니다. 게임에서 패배했습니다.");
                    break;
                }

                }

            }
        }
    }
