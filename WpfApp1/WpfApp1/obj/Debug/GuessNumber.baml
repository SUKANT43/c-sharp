   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.GuessNumber   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   $	��450��5   	   $	��800��6   .��5
      �� 
�������$��
0,0,0,-217q�6(   .+�5   
   �� $��Guess the Number!��6   $��24(�5      $
��Bold"�5      $��Center=�5      $	��Top=�5      $��0,20,0,0q�5      �� 5   
   $����Rules: You need to score 5 points to win the game. Each correct prediction earns you 1 point, while each wrong prediction deducts 1 point. If your score reaches -5, you lose the game. You need to enter number from 1 to 5 only.��6   $��24(�5      $
��Bold"�5      $��Center=�5      $	��Top=�5      $��0,20,0,0q�5      $
��Wrap=�5      �� 5   
   -   5          ��Name$  inputNumber��5   _   $	��100��6   $��40q�6   $	��100��6*   $��2q�67   
���   �6v   �� 5   
   -   5        $��Predict��5      $��80��6#   $��50��6.   
���   �$
��Bold"�6M   
�������$��20(�6r   6�   �� 5   
   $��Center=�6   $��10q�61   $
��Bold"�6=   $��30(�6O   
Your Score6i   �� 5   
   -   5         ��Name$ outputNumber��5   [   $��Center=�6   $��30(�61   $
��Bold"�6@   $��0��6R   6s   5      5      