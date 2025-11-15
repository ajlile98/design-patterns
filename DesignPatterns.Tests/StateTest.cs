using System;
using DesignPatterns.Patterns.Behavioral.State;
using Xunit;

namespace DesignPatterns.Tests;

public class StateTest
{
    [Fact]
    public void TestInitialState()
    {
        var streetLight = new StreetLight();
        Assert.Equal("Red", streetLight.GetCurrentLight());
        Assert.Same(RedLightState.Instance, streetLight.GetCurrentState());
    }
    
    [Fact]
    public void TestStateCycleTransitions()
    {
        var streetLight = new StreetLight();
        
        // Start with Red state
        Assert.Equal("Red", streetLight.GetCurrentLight());
        
        // Red -> Green  
        streetLight.TriggerLightCycle();
        Assert.Equal("Green", streetLight.GetCurrentLight());
        
        // Green -> Yellow
        streetLight.TriggerLightCycle();
        Assert.Equal("Yellow", streetLight.GetCurrentLight());
        
        // Yellow -> Red (complete cycle)
        streetLight.TriggerLightCycle();
        Assert.Equal("Red", streetLight.GetCurrentLight());
    }
    
    [Fact]
    public void TestSingletonStates()
    {
        var streetLight1 = new StreetLight();
        var streetLight2 = new StreetLight();
        
        // Both should start with same Red instance
        Assert.Same(RedLightState.Instance, streetLight1.GetCurrentState());
        Assert.Same(RedLightState.Instance, streetLight2.GetCurrentState());
        
        // Verify singleton instances are reused
        Assert.Same(RedLightState.Instance, streetLight1.GetCurrentState());
        Assert.Same(GreenLightState.Instance, GreenLightState.Instance);
        Assert.Same(YellowLightState.Instance, YellowLightState.Instance);
    }
    
    [Fact]
    public void TestStateInterface()
    {
        // Test that each state returns correct light color
        Assert.Equal("Red", RedLightState.Instance.GetCurrentLight());
        Assert.Equal("Green", GreenLightState.Instance.GetCurrentLight());
        Assert.Equal("Yellow", YellowLightState.Instance.GetCurrentLight());
    }
    
    [Fact]
    public void TestRapidCycling()
    {
        var streetLight = new StreetLight();
        
        // Test rapid state changes without delay
        for (int i = 0; i < 10; i++)
        {
            Assert.Equal("Red", streetLight.GetCurrentLight());
            streetLight.TriggerLightCycle();
            
            Assert.Equal("Green", streetLight.GetCurrentLight());
            streetLight.TriggerLightCycle();
            
            Assert.Equal("Yellow", streetLight.GetCurrentLight());
            streetLight.TriggerLightCycle();
        }
    }
    
    [Fact]
    public void TestStateTransitionLogic()
    {
        // Test individual state transitions directly
        var redState = RedLightState.Instance;
        var greenState = GreenLightState.Instance;
        var yellowState = YellowLightState.Instance;
        var streetLight = new StreetLight();
        
        // Red should transition to Green
        var nextState = redState.CycleChange(streetLight);
        Assert.Same(GreenLightState.Instance, nextState);
        
        // Green should transition to Yellow
        nextState = greenState.CycleChange(streetLight);
        Assert.Same(YellowLightState.Instance, nextState);
        
        // Yellow should transition to Red
        nextState = yellowState.CycleChange(streetLight);
        Assert.Same(RedLightState.Instance, nextState);
    }
    
    [Fact]
    public void TestMultipleStreetLightsIndependence()
    {
        var light1 = new StreetLight();
        var light2 = new StreetLight();
        var light3 = new StreetLight();
        
        // Advance each light to different states
        light2.TriggerLightCycle(); // Green
        light3.TriggerLightCycle(); // Green
        light3.TriggerLightCycle(); // Yellow
        
        // Verify they're in different states
        Assert.Equal("Red", light1.GetCurrentLight());
        Assert.Equal("Green", light2.GetCurrentLight());
        Assert.Equal("Yellow", light3.GetCurrentLight());
        
        // Verify they can change independently
        light1.TriggerLightCycle();
        Assert.Equal("Green", light1.GetCurrentLight());
        Assert.Equal("Green", light2.GetCurrentLight()); // unchanged
        Assert.Equal("Yellow", light3.GetCurrentLight()); // unchanged
    }
}