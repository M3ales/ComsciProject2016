﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace ComsciProject.Engine.PacMan
{
    //Controllable character
    class PacManPlayer : Entity
    {
        public PacManPlayer()
        {
            appearance = 'C';
            descName = "Pac-Man";
        }
        //Remove the cheap code here, its to test and show example of Input class
        bool isLeft = false;
        public override void Update()
        {
            if (Input.getLastKeypress() == Key.Left)
                isLeft = true;
            else if (Input.getLastKeypress() == Key.Right)
                isLeft = false;
            Move(isLeft ? Vector2.left*2 : Vector2.right*2); //if left, move left, else right
        }

        public override void LateUpdate()
        {
            //Move(new Vector2(1, 0)); <- this makes it move 2 times in one 'update'
            //this is not desired behaviour, rather use
            //Move(new Vector2(2,0));
            //or if you're fancy
            //Move(Vector2.right*2);
        }
    }
}
