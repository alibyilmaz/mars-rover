using mars_rover;
using System;
using Xunit;

namespace mars_rover_test
{
    public class RoverShould
    {
        [Fact]
        public void SpinLeft()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinLeft();
            //assert
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void SpinRight()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.SpinRight();
            //assert
            Assert.Equal("E", rover.direction);
        }

        [Fact]
        public void StepForward()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.StepForward();
            //assert
            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void Moveto1_3_N()
        {
            //arrange
            Rover rover = new Rover("1 2 N");
            //act
            rover.Moveto1_3_N("LMLMLMLMM");
            //assert
            Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }
        [Fact]
        public void Moveto5_1_E()
        {
            //arrange
            Rover rover = new Rover("3 3 E");
            //act
            rover.Moveto5_1_E("MMRMMRMRRM");
            //assert
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
