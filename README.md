## #1 Aplikacja ***FitBooster***

Prosta aplikacja, pozwalająca na tworzenie własnych jadłospisów na każdy dzień i eksportowanie ich do plików tekstowych oraz na korzystanie z kalkulatorów dietetycznych.

Aplikacja wykonana na potrzeby projektu semestralnego z przedmiotu **Programowanie obiektowe - WSEI Kraków**.

**Autorzy:**
 - Adrian Kurek - https://github.com/artysta
 - Natalia Krawczyk - https://github.com/nat13alia

## #2 Początkowe założenia

**Wstępnie** aplikacja pozwalała będzie na:
- tworzenie własnych jadłospisów, na podstawie już istniejących w aplikacji produktów spożywczych - ułożony przez użytkownika jadłospis będzie zawierał informacje na temat kaloryczności posiłków i zawartości makroskładników,
- dodawanie własnych produktów spożywczych wraz z informacjami na ich temat (ilość kalorii, węglowodanów, białek, tłuszczów),
- korzystanie z kalkulatorów dietetycznych:
   - **BMI** - wskaźnika masy ciała,
   - **AMR** - czynnej przemiany materii,
   - **BMR** - podstawowej przemiany materii,
   - **TER** - dziennego zapotrzebowania na energię,

## #3 Prototyp GUI aplikacji

<table>D
   <tr>
      <td>
         <img src="/screenshots/home_page.png" alt="home_page.png"/>
      </td>
      <td>
         <img src="/screenshots/bmi_bmr_amr_ter_calculators.png" alt="bmi_bmr_amr_ter_calculators.png"/>
      </td>
      <td>
         <img src="/screenshots/food_diary.png" alt="food_diary.png"/>
      </td>
   </tr>
</table>


## #1 Application ***FitBooster***

A simple application that allows to create your own meal plans for every day, to export them into text files and to calculate your BMI etc. based on your body parameters.

The application was created as a project for the needs of the course **Programowanie obiektowe - WSEI Kraków**

**Authors:**
 - Adrian Kurek - https://github.com/artysta
 - Natalia Krawczyk - https://github.com/nat13alia

## #2 Initial Assumptions

**Preliminarily** the application will allow you to:
- create your own meal plans, on the basis of the products already existing in the application - formed by the user meal plan will provide the information about the energy value of meals and their nutritional facts,
- add your own products with the necessary details (amount of calories, carbs, proteins and fat),
- use various calculatours, such as:
   - **BMI** - body mass index,
   - **AMR** - active metabolic rate,
   - **BMR** - basal metabolic rate,
   - **TER** - total expense ratio,

## #3 GUI prototype of the application

<table>D
   <tr>
      <td>
         <img src="/screenshots/home_page.png" alt="home_page.png"/>
      </td>
      <td>
         <img src="/screenshots/bmi_bmr_amr_ter_calculators.png" alt="bmi_bmr_amr_ter_calculators.png"/>
      </td>
      <td>
         <img src="/screenshots/food_diary.png" alt="food_diary.png"/>
      </td>
   </tr>
</table>


---

## #4 Documentation of FitBoosterLibrary

### `Product` - class that stores informations about product.

#### Method summary

`string _name` - just name of product.

`string _description` - short description of product.

`string _unit` - unit of measurement (grams or mililiters).

`double _weight` - weight (in grams) or capacity (in mililiters) of one product package.

`double _calories` - amount of calories contained in one package of product.

`double _fat` - amount of fat (in grams) contained in one package of product.

`double _carbs` - amount of carbohydrates (in grams) contained in one package of product.

`double _proteins` - amount of proteins (in grams) contained in one package of product.

`string Name` - property that sets or returns name of the product.

`string Description` - property that sets or returns description of the product.

`string Unit` - property that sets or returns unit of the product.

`double Weight` - property that sets or returns weight of the product package.

`double Calories` - property that sets or returns calories of the product package.

`double Fat` - property that sets or returns fat contained in one product package.

`double Carbs` - property that sets or returns carbs contained in one product package.

`double Proteins` - property that sets or returns proteins contained in one product package.

`double GetCaloriesPerAmount(int amount)` - returns amount of calories in `amount` param grams or mililiters of product rounded up to 2 decimal places.

`double GetFatPerAmount(int amount)` - returns amount of fat in X (amount param) grams or mililiters of product.

`double GetCarbsPerAmount(int amount)` - returns amount of carbohydrates in X `amount` param grams or mililiters of product.

`double GetProteinsPerAmount(int amount)` - returns amount of proteins in `amount` param grams or mililiters of product.

`string GetProductAmountInfo(int amount)` - returns text information about `amount` param grams or mililiters of product.

`string GetProductPackageInfo()` - returns text information about package of product.

`string ToString()` - just overrided `ToString` method.

---

### `XMLProductsParser` - class that allow to save (or load) informations about product to XML file. It provides data for the application.

#### Method summary

`readonly string path` - path of file that contains informations about products.

`void AddProduct(Product product)` - adds new product to XML file.

`List<Product> GetAllProducts()` - returns list of products loaded from XML file.

---

### `IProductsProvider` - interface that should be implemented by classes that want to provide products for the application

#### Method summary

`void AddProduct(Product product)` - add new product.

`void RemoveProduct(Product product)` - remove product.

`List<Product> GetAllProducts()` - returns list of all products.

### `Diet` - class that stores informations about diet.

#### Method summary

`string _name` - name of diet.

`string _description` - description of diet.

`List<DietProduct> _products` - list of products of diet.

`string Name` - property that returns or sets name of diet.

`string Description` - property that returns or sets description of diet;

`double TotalCalories` - returns total calories of all products included in diet.

`List<DietProduct> Products` - returns or sets list of products.

`public void AddProduct(DietProduct product)`

`void RemoveProduct(DietProduct product)` - removes diet product from the list.

`double GetTotalCalories()` - returns amount of total calories of diet.

`string GetDietInfo()` - returns text information about diet.

---

### `DietProduct` - class that stores informations about product included in diet and bout its amount

#### Method summary

`Product _product` - just product.

`int _amount` - the amount of product added to the diet.

`Product Product` - returns or sets product.

`int Amount` - returns or sets amount of product added to the diet.

`string Name` - returns or sets name of the product.
 
`string Description` - returns or sets description of the product.

`string Unit` - returns or sets unit of measurement of one product package.

`double Weight` - returns or sets amount of product added to the diet.

`double Calories` - returns or sets amount of calories contained in one product package.
 
`double Fat` - returns or sets amount of fat contained in amount of product product.

`double Carbs` - returns or sets amount of carbohydrates contained in amount of product product.

`double Proteins` - returns or sets amount of proteins contained in amount of product product.

---

### `XMLDietsParser` - class that allows to save (or load) informations about diet to XML file. It provides data for the application.

#### Method summary

`readonly string path` - path of file that contains informations about diets.

`void AddDiet(Diet diet)` - adds new diet to XML file.

`List<Diet> GetAllDiets()` - returns list of diets loaded from XML file.

---

### `IDietsProvider` - interface that should be implemented by classes that want to provide diets for the application

#### Method summary

`void AddDiet(Diet diet)` - add new diet.

`void RemoveDiet(Diet diet)` - remove diet.

`List<Diet> GetAllDiets()` - returns list of all diets.

---

### `Parameter` - class that helps storing user parameters.

#### Method summary

`double _weight` - weight parameter.

`double _bmi`- BMI parameter.

`double _targetBmi` - target BMI parameter.

`double Weight` - property that returns or sets weight parameter.

`double Bmi` - property that returns or sets BMI parameter.

`double TargetBmi` - property that returns or sets target BMI parameter.

`DateTime LastUpdated` - property that returns or sets last updated date.

---

### `XMLParametersParser` - class that allow to save (or load) user parameters to XML file. It provides data for the application.

#### Method summary

`readonly string path` - path of file that contains informations about parameters.

`void AddParameter(Parameter parameter)` - adds new parameter to XML file.

`Parameter GetLatestParameter()` - returns most recent parameter class.

---

### `Calculator` - class that provides different types of calculator methods.

#### Method summary

`readonly static double MAX_HEIGHT` - maximum height in centimeters.

`readonly static double MAX_WEIGHT` - maximum weight in kilograms

`readonly static int MAX_AGE` -  maximum age in years.

`readonly static double MAX_ACTIVITY_RATE` - maximum activity rate.

`readonly static double LOW_ACTIVITY` - low activity.

`readonly static double MEDIUM_ACTIVITY` - medium activity.

`readonly static double HIGH_ACTIVITY` - high activity.

`double CalculateBMI(double weight, double height)` - returns BMI (Body Mass Index).

`double CalculateBMR(double weight, double height, int age, Genders gender)` - returns BMR (Basal Metabolic Rate)

`public double CalculateAMR(double weight, double height, int age, Genders gender, double activityRate)` - returns AMR (Active Metabolic Rate)
