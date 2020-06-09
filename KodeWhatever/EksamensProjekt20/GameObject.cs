﻿using EksamensProjekt20.MapNManager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjekt20.Characters;
using EksamensProjekt20.Buffs;
using System.Runtime.CompilerServices;
using DiagnosticsUtils;

namespace EksamensProjekt20
{
    class GameObject : ScreenObject
    {

        public string tag;
        public bool isGrounded = false;
        public Vector2 velocity;
        public Vector2 moveVector;
        public Vector2 gamePosition;
        public float movementSpeed;


        public override void Update(float deltaTime)
        {
            Gravity(deltaTime);
            Movement(deltaTime);
            base.Update(deltaTime);
        }

        public void GroundCollisionDetection(GameObject other)
        {
            GameObject t = other;

            //t = terrain | this = player/enemy
            if (other.tag == "Terrain" && this.tag != "Terrain")
            {

                //Bottom Player Collision //(this.spriteRect.Top + this.velocity.Y < t.spriteRect.Bottom && this.spriteRect.Bottom > t.spriteRect.Bottom && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right)
                if (this.spriteRect.Bottom + this.velocity.Y > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Top && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right /*&& isGrounded == false*/)
                { 
                    int height = spriteRect.Bottom - other.spriteRect.Top;
                    gamePosition.Y -= height;

                    isGrounded = true;

                }
                //Top Player Collision //(this.spriteRect.Bottom + this.velocity.Y > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Top && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right /*&& isGrounded == false*/)
                if (this.spriteRect.Top + this.velocity.Y < t.spriteRect.Bottom && this.spriteRect.Bottom > t.spriteRect.Bottom && this.spriteRect.Right > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Right)
                {
                    velocity = new Vector2(velocity.X, velocity.Y - velocity.Y * 2);
                }
                //Right Player Collision
                if (this.spriteRect.Left + this.velocity.X < t.spriteRect.Right && this.spriteRect.Right > t.spriteRect.Right && this.spriteRect.Bottom > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Bottom /*&& isGrounded == false*/)
                {
                    int width = spriteRect.Left - other.spriteRect.Right;
                    gamePosition.X -= width;
                }
                //Left Player Collision
                if (this.spriteRect.Right + this.velocity.X > t.spriteRect.Left && this.spriteRect.Left < t.spriteRect.Left && this.spriteRect.Bottom > t.spriteRect.Top && this.spriteRect.Top < t.spriteRect.Bottom /*&&                                              isGrounded == false*/)
                {
                    int width = spriteRect.Right - other.spriteRect.Left;
                    gamePosition.X -= width;
                }
                else
                {
                    isGrounded = false;
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
                //c er den character vi kolliderer med


                if (/*TOP*/c.spriteRect.Top >= this.spriteRect.Top &&/*BOTTOM*/ c.spriteRect.Bottom <= this.spriteRect.Bottom &&/*RIGHT*/ c.spriteRect.Right <= this.spriteRect.Right &&/*LEFT*/ c.spriteRect.Left >= this.spriteRect.Left) 
                {
                    c.AddBuff(new Burn(/*DMG*/10,/*DURATION SEC*/10,/*TICKCOUNT*/10,/*THE TARGET*/c));
                }
            }

        }
        public void Jump()
        {
            if (isGrounded == true)
            {
                velocity = new Vector2(velocity.X, -2);
                isGrounded = false;
            }
        }

        public void Gravity(float deltaTime)
        {

            if (isGrounded == false)
            {
                velocity += new Vector2(0, 1) * deltaTime;
            }
            else if (isGrounded == true)
            {
                velocity.Y = 0;

            }

        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            screenPosition = gamePosition + Stage.stageVector - (spriteSize / 2);
            base.Draw(spriteBatch);
        }
        public void Movement(float deltaTime)
        {
            gamePosition += moveVector * movementSpeed * deltaTime + velocity * deltaTime;
            //gamePosition.Y += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds / 10000;
        }
    }
}
