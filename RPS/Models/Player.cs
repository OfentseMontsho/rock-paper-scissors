using System;
using System.Collections.Generic;
using System.Text;

//Tracking of the damange, player move streaks & HP:
namespace RPS.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public Move? LastMove { get; set; }
        public bool IsActive => CurrentHP > 0;

        public Player(string name, int maxHP)
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
        }

        public void DamageTaken(int amount)
        {
            CurrentHP = Math.Max
                (0,
                CurrentHP - amount);
        }

        public void Win(Move winningMove)
        {
            LastMove = winningMove;
        }

        public void ResetMoves()
        {
            LastMove = null;
        }
    }
}
