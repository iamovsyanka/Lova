   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      $    Presentation.Views.AddTestView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  AddTestView��5	       � DataContext 5      .   (Presentation.ViewModels.AddTestViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $' !..\Views\Resource\Style\Test.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��235* �6   �� 5      $
��323* �6   �� 5      $
��242* �6    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��79* �6   �� 5      $
��112* �6   �� 5      $	��79* �6   �� 5      $
��136* �6   .+�5    
   �� $��0��6   $��Тест��6   $��1��6,   �� 5!   
   $��1��6   $��Название:��6!   $��18(�62   $��Center=�6@   $��Center=�6[   �� 5"   
   $��1��6   $��1��6   $	��321��6I   $��40��6U    �� TextWrapping$ WrapWithOverflow=�6a   ��6/   �� *
TestName+.��6�    � ToolTip$I CТекст не должен начинаться с пробела��5#   T   .��5$      �� 5%   
   $��2��6   $��Описание:��6!   $��18(�62   $��Center=�6@   $��Center=�6[   �� 5&   
   $��2��6   $��1��6   $	��322��6P   $��68��6\   $ WrapWithOverflow=�6h   ��6/   �� *TestDescription+.��6�   $I CТекст не должен начинаться с пробела��5'   T   .��5(      �� 5)   
   $��3��6   $��Категория:��6!   $��18(�63   $��Center=�6A   $��Center=�6\   �� 5*   
   $��3��6   $��1��6   $	��321��6M   $��43��6Y   ��6/   �� *TestCategory+.��6e   $I CТекст не должен начинаться с пробела��5+   T   .��5,      �� 5-   
   $��4��6   $��1��6   $��Добавить тест��6.   $	��254��6F   $��52��6R   ��6^   �� *AddTestCommand+�� 5.   
   $��2��6   $��1��6    $��2��6-   $%��..\Views\Resource\Image\Add.png��6>   �� 5/   
   $��2��6   $��4��6!   $��Удалить тест��6.   ��6E   �� *RemoveTestCommand+50      51      