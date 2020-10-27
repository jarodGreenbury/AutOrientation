using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class deathScriptTests
{
    [Test]
    public void calculateScore_Test()
    {
        //ARRANGE
        var scoreCalculator = new deathScript();
        var playerLevel = 2;
        var playerExp = 5;
        var expectedScore = ((1 * 5) + (2 * 5));

        //ACT
        var testScore = scoreCalculator.calculateScore(playerLevel, playerExp);

        //ASSERT
        Assert.That(testScore, Is.EqualTo(expectedScore));
    }
    [Test]
    public void calculateScore_Test2()
    {
        //ARRANGE
        var scoreCalculator = new deathScript();
        var playerLevel = 4;
        var playerExp = 6;
        var expectedScore = ((1 * 6) + (2 * 6) + (3 * 6) + (4 * 6));

        //ACT
        var testScore = scoreCalculator.calculateScore(playerLevel, playerExp);

        //ASSERT
        Assert.That(testScore, Is.EqualTo(expectedScore));
    }
}
