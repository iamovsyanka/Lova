   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      '    !Presentation.Views.LevensteinView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  LevensteinView��5	       � DataContext 5      1   +Presentation.ViewModels.LevensteinViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $- '..\Views\Resource\Style\Calculator.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��293* �6   �� 5      $
��293* �6   �� 5      $
��214* �6    � RowDefinitions 5   
   �� 5      $	��17* �6   �� 5      $	��96* �6   �� 5      $
��112* �6   .+�5   
   �� $��1��6   $��2��6!   $/��)Дистанция Левенштейна��6.   $	��195��6t   ��6N   �� *LevensteinCommand+6t   �� 5   
   $��2��6   $��2��6!   $��
Форум��6.   $��0,25,0,0q�6c   $	��Top=�6u   ��6>   �� *GoToForumCommand+6u   �� 5   
   $��2��6   $��2��6!   $��
Тесты��6.   ��6>   �� *GoToTestCommand+�� 5    
   $��2��6   $��2��6!   $��Калькулятор��6.   $��	0,157,0,0q�6n   $	��Top=�6�   ��6D   �� *GoToCalculatorCommand+6�   �� 5!   
   $��1��6   $��0��6!   $��Первая строка��61   $��Center=�6F   $��16(�6c   $��
0,32,0,124q�6q   �� 5"   
   $��1��6   $��1��6!   $��Вторая строка��61   $��Center=�6F   $��16(�6c   $��
0,32,0,124q�6q   �� 5#   
   $��1��6   $	��221��6   $��47��6+   ��67   �� *FirstString+ �� Mode$ TwoWay=��� 5$   
   $��1��6   $��1��6   $	��221��6/   $��47��6;   ��6G   �� *SecondString+$ TwoWay=��� 5%   
   $��2��6   $��0��6!   $
��Wrap=�6I   $��18(�6]   $
��Bold"�6k   ��61   �� *Result+6k   5&      5'      