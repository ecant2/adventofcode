using System;
using AdventOfCode.FloorCalculator;
using AdventOfCode.IdealLightingConfigurationCalculator;
using AdventOfCode.NiceStringCalculator;
using AdventOfCode.WrappingMaterialCalculator;

namespace AdventOfCode {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("*** Some Assembly Required ***");
      Console.WriteLine("Where can we find the instructions for assembling the circuit?");
      var path = Console.ReadLine();
      var multiLineInput = new MultiLineInput<Instruction>(path, InstructionFactory.Instance);
      var circuitSignalCalculator = new CircuitSignalCalculator();
      circuitSignalCalculator.CreateCircuit(multiLineInput.GetInput());
      var signalOnA = circuitSignalCalculator.GetSignalOn("a");
      Console.WriteLine("Signal {0} is ultimately provided to wire a.", signalOnA);
      circuitSignalCalculator.SetSignalOn("b", signalOnA);
      signalOnA = circuitSignalCalculator.GetSignalOn("a");
      Console.WriteLine("New signal {0} is ultimately provided to wire a.", signalOnA);


      Console.WriteLine("*** Probably a Fire Hazard ***");
      Console.WriteLine("Where can we find the instructions on how to display the ideal lighting configuration?");
      path = Console.ReadLine();
      var idealLightingConfigurationCalculatorInput = new IdealLightingConfigurationCalculatorInput(path);
      var idealLightingConfigurationCalculator = new IdealLightingConfigurationCalculator.IdealLightingConfigurationCalculator();
      var lightingLightsCount = idealLightingConfigurationCalculator.GetAmountOfSimpleLightingLights(idealLightingConfigurationCalculatorInput.GetInput());
      Console.WriteLine("{0} lights are lit.", lightingLightsCount);
      var totalBrightness = idealLightingConfigurationCalculator.GetAmountOfTristateLightingLights(idealLightingConfigurationCalculatorInput.GetInput());
      Console.WriteLine("{0} lights are lit.", totalBrightness);

      Console.WriteLine("*** Doesn't He Have Intern-Elves For This? ***");
      Console.WriteLine("Where can we find the naughty and nice input strings?");
      path = Console.ReadLine();
      var niceStringCalculatorInput = new NiceStringCalculatorInput(path);
      var niceStringCalculator = new NiceStringCalculator.NiceStringCalculator();
      var niceStringCount = niceStringCalculator.GetNiceStringCount(niceStringCalculatorInput.GetInput());
      Console.WriteLine("There are {0} nice strings.", niceStringCount);
      var nicerStringCount = niceStringCalculator.GetNicerStringCount(niceStringCalculatorInput.GetInput());
      Console.WriteLine("There are {0} nicer strings.", nicerStringCount);

      Console.WriteLine("*** The Ideal Stocking Stuffer ***");
      Console.WriteLine("What's the secret key Santa has to use for AdventCoins mining?");
      var secretKey = Console.ReadLine();
      var md5HashesCalculator = new MD5HashesCalculator.MD5HashesCalculator();
      var suffix = md5HashesCalculator.GetSuffixForSecretKeyResultingInHashWithLeadingZeros(secretKey, 5);
      Console.WriteLine("The secret key with suffix {0} will result in a hash with 5 leading zeros.", suffix);
      suffix = md5HashesCalculator.GetSuffixForSecretKeyResultingInHashWithLeadingZeros(secretKey, 6);
      Console.WriteLine("The secret key with suffix {0} will result in a hash with 6 leading zeros.", suffix);

      Console.WriteLine("*** Perfectly Spherical Houses in a Vacuum ***");
      Console.WriteLine("Where can we find the input to help Santa delivering presents?");
      path = Console.ReadLine();
      var input = OneLinerInput.GetInput(path);
      var deliveryCalculator = new DeliveryCalculator.DeliveryCalculator();
      var deliveryCount = deliveryCalculator.GetTotalDeliveries(input);
      Console.WriteLine("At least on present is delivered to {0} houses.", deliveryCount);
      var speedDeliveryCount = deliveryCalculator.GetTotalDeliveriesSpeededUp(input);
      Console.WriteLine("At least on present is delivered with speed to {0} houses.", speedDeliveryCount);

      Console.WriteLine("*** I Was Told There Would Be No Math ***");
      Console.WriteLine("Where can we find the input to help the elves order wrapping paper?");
      path = Console.ReadLine();
      var wrappingMaterialCalculatorInput = new WrappingMaterialCalculatorInput(path);
      var wrappingMaterialCalculator = new WrappingMaterialCalculator.WrappingMaterialCalculator();
      var squareFeet = wrappingMaterialCalculator.GetTotalSquareFeetWrappingPaper(wrappingMaterialCalculatorInput.Transform());
      Console.WriteLine("The elves can order {0} square feet wrapping paper.", squareFeet);
      var feet = wrappingMaterialCalculator.GetTotalFeetRibbon(wrappingMaterialCalculatorInput.Transform());
      Console.WriteLine("The elves can order {0} feet ribbon.", feet);

      Console.WriteLine("*** Not Quite Lisp ***");
      Console.WriteLine("Where can we find the input to help find Santa the right floor?");
      path = Console.ReadLine();
      input = OneLinerInput.GetInput(path);
      var floorCalculator = new FloorCalculator.FloorCalculator(new SingularMove());
      var floorNumber = floorCalculator.GetFinalFloorPosition(input);
      Console.WriteLine("Santa should go to the {0}th floor.", floorNumber);
      var moveToBasement = floorCalculator.GetFirstMoveThatCausesEnteringBasement(input);
      Console.WriteLine("Santa entered the basement the first time after {0} moves.", moveToBasement);

      Console.ReadLine();
    }
  }
}
