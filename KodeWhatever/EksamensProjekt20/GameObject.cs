﻿using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Characters;
using EksamensProjekt20.Buffs;
using System.Runtime.CompilerServices;

namespace EksamensProjekt20
{
    class GameObject : ScreenObject
    {

        public string tag;
        public bool isGrounded;
        public Vector2 velocity;
        public Vector2 gamePosition;
        

        

        public void GroundCollisionDetection(GameObject other)
        {
            TerrainPiece t = (TerrainPiece)other;

            //Har hvad vi kollidere med Tag Terrain
            //FIX COLLISION CALCULATIONS t.spriteRect.Top/Bottom/Left/Right
            if (other.tag == "Terrain")
            {
                //Bottom Player Collision
                if (t.gamePosition.Y - t.sprite.Height / 2 < this.gamePosition.Y + this.sprite.Height / 2 && t.gamePosition.Y - t.sprite.Height / 3 > this.gamePosition.Y + this.sprite.Height / 2 && t.gamePosition.X - t.sprite.Width / 3 * 1.40 < this.gamePosition.X + this.sprite.Width / 2 && t.gamePosition.X + t.sprite.Width / 3 * 1.40 > this.gamePosition.X - this.sprite.Width / 2)
                {
                    int height = spriteRect.Bottom - other.spriteRect.Top;
                    gamePosition.Y -= height;

                    isGrounded = true;

                }
                //Top Player Collision
                if (t.gamePosition.Y + t.sprite.Height / 2 > this.gamePosition.Y - this.sprite.Height / 2 && t.gamePosition.X - t.sprite.Width / 3 * 1.40 < this.gamePosition.X + this.sprite.Width / 2 && t.gamePosition.X + t.sprite.Width / 3 * 1.40 > this.gamePosition.X - this.sprite.Width / 2 && isGrounded == false)
                {
                    velocity = new Vector2(velocity.X, velocity.Y - velocity.Y * 2);
                }
                //Right Player Collision
                if (t.gamePosition.X - this.sprite.Width / 2 >= this.gamePosition.X + this.sprite.Width / 2 && t.gamePosition.X > this.gamePosition.X + sprite.Width / 2 && t.gamePosition.Y + t.sprite.Height / 3 > this.gamePosition.Y - this.sprite.Height / 2 && isGrounded == false)
                {
                    int width = spriteRect.Right - other.spriteRect.Left;
                    gamePosition.X -= width;
                }
                //Left Player Collision
                if (t.gamePosition.X + this.sprite.Width / 2 <= this.gamePosition.X - this.sprite.Width / 2 && t.gamePosition.X < this.gamePosition.X - sprite.Width / 2 && t.gamePosition.Y + t.sprite.Height / 3 > this.gamePosition.Y - this.sprite.Height / 2 && isGrounded == false)
                {
                    int width = spriteRect.Left - other.spriteRect.Right;
                    gamePosition.X -= width;
                }
            }
        }
        public void CharacterCollisionDetection(Character other1)
        {
            Character c = (Character)other1;
            if (other1.currentHealth >= 1)
            {
                // Y- = OP
                // Y+ = NED
                // X- = Venstre
                // X+ = Højre
                //c er den charecter vi kollidere med


                if (/*TOP*/c.spriteRect.Top >= this.spriteRect.Top &&/*BOTTOM*/ c.spriteRect.Bottom <= this.spriteRect.Bottom &&/*RIGHT*/ c.spriteRect.Right <= this.spriteRect.Right &&/*LEFT*/ c.spriteRect.Left >= this.spriteRect.Left) 
                {
                    c.AddBuff(new Burn(/*DMG*/10,/*DURATION SEC*/10,/*TICKCOUNT*/10,/*THE TARGET*/c));
                }
            }

        }
        private void Jump()
        {
            isGrounded = false;
            velocity = new Vector2(velocity.X, -2);
        }

        private void Gravity(GameTime gametime)
        {
            if (isGrounded == false)
            {
                velocity += new Vector2(0, 2 * (float)gametime.ElapsedGameTime.TotalSeconds);
            }
            else
            {
                velocity = Vector2.Zero;
            }

        }
    }
}
