   M S B A M L   `   `   `  ����H  DRecipeAppWPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RecipeAppWPF1RecipeAppWPF1  5   	   #    RecipeAppWPF1.AddRecipeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RecipeAppWPF1     5   	     � Title$  
Add Recipe��5      $	��450��6%   $	��400��62   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Recipe Name:��6   �� 5   
   -   5        $��RecipeNameTextBox��5      $��1��6+   �� 5   
   $��Ingredients:��6   $��2��6(   $��0,10,0,0q�65   �� 5   
   -   5        $��IngredientsListView��5      $��3��6.   $	��100��6;   $��0,0,0,10q�6H    �� View 5      �� 5      .P�5      �� $
��Name��6%    �� Width$	 100��6Y    �� DisplayMemberBinding 63   �� *Name+6Y   �� 5      $��Quantity��6%   $ 50��6a    67   �� *
Quantity+6a   �� 5      $
��Unit��6%   $ 50��6Y    63   �� *Unit+6Y   �� 5      $��Calories��6%   $ 50��6a    67   �� *
Calories+6a   �� 5      $��
Food Group��6%   $	 100��6d    69   �� *	FoodGroup+6d   5      5       �� 5"   
   $��4��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5#      �� -   5        $��Add Ingredient��5#      $��0,0,10,0q�6J   �� 5$      -   5        $��Save Recipe��5$      6+   5%      5&      5'      