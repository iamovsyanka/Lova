   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      &     Presentation.Views.UsersTestView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  UserTest��5	       � DataContext 5      0   *Presentation.ViewModels.UsersTestViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $' !..\Views\Resource\Style\Test.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��214* �6   �� 5      $	��93* �6   �� 5      $	��93* �6    � RowDefinitions 5   
   �� 5      $	��28* �6   �� 5      $
��223* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   .+�5   
   �� $��2��6   $��0��6$   $-��'Результаты студентов��64   $��0��6S   $	��Top=�6`   $	��Top=�6   $
��Left=�6�   $��
302,-8,0,0q�6�   &   System.Windows.Controls.DataGrid  5    
   $��0��6   $��1��6#   $��3��60   $��Center=�6c   ��6A   �� *	UserTests+   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$! Название теста��6B      
IsReadOnly$
 True��6Z   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 6l   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *
TestName+6l     5#      $ Результаты��6@   $
 True��6T   
 6%   �� *Result+6T     5$      $' !Время прохождения��6D   $
 True��6_   
 6%   �� *
SolvedTime+6_     5%      $ Пользователь��6B   $
 True��6X   
 6%   �� *
UserName+6X   5'      �� 5(   
   $��1��6   $��2��6!   $��
Форум��6.   $��40��6c   $	��170��6o   ��6>   �� *GoToForumCommand+6o   �� 5)   
   $��2��6   $��1��6%   $��3��65   $��
Тесты��6B   $��40��6v   $	��170��6�   ��6R   �� *GoToTestCommand+6�   �� 5*   
   $��2��6   $��2��6!   $��Калькулятор��6.   ��6D   �� *GoToCalculatorCommand+�� 5+   
   $��1��6   $��2��6    $��1��64   $(��"..\Views\Resource\Image\Result.png��6A   $��Center=�6m   $��Center=�6�   $	��180��6�   5,      5-      