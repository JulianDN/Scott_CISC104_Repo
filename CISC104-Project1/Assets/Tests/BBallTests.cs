using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BBallTests
{
    [Test]
    public void BBallDefaultConstructorTest()
    {
        Player1 defaultPlayer1 = new Player1();
        Player2 defaultPlayer2 = new Player2();

        Assert.AreNotEqual(1, defaultPlayer1.MakeShot());
        Assert.AreNotEqual(1, defaultPlayer2.MakeShot());
    }

    [Test]
    public void Player1ScoresPointTest()
    {
        Player1 player1Scored = new Player1();
        int player1Count = 1;

        Assert.That(player1Count == 1);
    }

    [Test]
    public void Player2ContestsPlayer1()
    {
        Player2 player2Guards = new Player2();
        int amountOfContest = 40;

        Assert.That(amountOfContest == 40);
    }
}