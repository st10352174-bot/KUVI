   M S B A M L   `   `   `  ����H  DRecipeAppWPF1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RecipeAppWPF1RecipeAppWPF1  5   	       RecipeAppWPF1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RecipeAppWPF1     5   	     � Title$  Culinary Companion��5      $	��450��6,   $	��800��69   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��10q�6K   .+�5      �� -   5        $��
Add Recipe��5      $	��100��6*   66   �� 5      -   5        $��Display Recipe��5      $	��100��6.   $
��10,0q�6:   6H   �� 5      -   5        $��Adjust Recipe��5      $	��100��6-   69   �� 5      -   5        $��Reset Quantities��5      $	��100��60   $
��10,0q�6<   6J   �� 5      -   5        $��Clear Recipe��5      $	��100��6,   68   �� 5      -   5        $
��Exit��5      $	��100��6$   $
��10,0q�60   6>   5      �� 5   
   $��1��6   $��10q�6"   .+�5      �� $��Recipe Name:��6   �� 5      -   5        $��RecipeNameTextBox��5      $	��200��6/   �� 5      $��Ingredients:��6   $��0,10,0,0q�6,   �� 5      -   5        $��IngredientsListView��5      $	��100��62    �� View 5      �� 5      .P�5       �� $
��Name��6)    �� Width$	 100��6]    �� DisplayMemberBinding 67   �� *Name+6]   �� 5!      $��Quantity��6)   $ 50��6e    6;   �� *
Quantity+6e   �� 5"      $
��Unit��6)   $ 50��6]    67   �� *Unit+6]   �� 5#      $��Calories��6)   $ 50��6e    6;   �� *
Calories+6e   �� 5$      $��
Food Group��6)   $	 100��6h    6=   �� *	FoodGroup+6h   5%      5'      �� 5)      $��Steps:��6   $��0,10,0,0q�6&   �� 5*      -	   5        $��StepsListView��5*      $	��100��6,    5+      �� 5,      .P�5-      �� $
��Step��6)   $	 200��6X    67   �� 6X   5.      50      51      52      53      