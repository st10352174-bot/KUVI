   M S B A M L   `   `   `  ����H  DRecipeAppWPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RecipeAppWPF1RecipeAppWPF1  5   	   '    !RecipeAppWPF1.AddIngredientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RecipeAppWPF1     5   	     � Title$  Add Ingredient��5      $	��300��6'   $	��300��64   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Name:��6   $��0��6!   �� 5   
   -   5        $��IngredientNameTextBox��5      $��1��6/   �� 5   
   $��	Quantity:��6   $��2��6%   $��0,10,0,0q�62   �� 5   
   -   5        $��QuantityTextBox��5      $��3��6)   �� 5   
   $��Unit:��6   $��4��6!   $��0,10,0,0q�6.   �� 5   
   -   5        $��UnitTextBox��5      $��5��6%   �� 5!   
   $��	Calories:��6   $��6��6%   $��0,10,0,0q�62   �� 5"   
   -   5        $��CaloriesTextBox��5"      $��7��6)   �� 5$   
   $��Food Group:��6   $��8��6'   $��0,10,0,0q�64   �� 5%   
   -   5        $��FoodGroupTextBox��5%      $��9��6*   �� 5'   
   -   5        $��Add Ingredient��5'      $��10��6*   $��Center=�6T   $��Center=�6q   5(      5)      