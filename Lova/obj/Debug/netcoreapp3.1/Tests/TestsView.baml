   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      "    Presentation.Views.TestsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  Tests��5	       � DataContext 5      ,   &Presentation.ViewModels.TestsViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $' !..\Views\Resource\Style\Test.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��621* �6   �� 5      $
��179* �6    � RowDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��60* �6   �� 5      $	��57* �6   �� 5      $
��127* �6   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $	��35* �6   .+�5    
   �� $��2��6   $��
Тесты��6$   $��31��64   $��60��6@   � 5!   
   $��1��6   $��4��6   $��0��6-   .+�5"      �� ��6   �� *Tests+ �� SelectedItem 65   �� *SelectedTest+��5#      �� 5$      .R�5%      �� .+�5&      �� ���#8570E0$��1q�6;   $	��600��6O   ._�5'   "   �� .+�5(   &   ��  �� Orientation$ 
Horizontal=�61   .+�5)   *   �� $��Название: ��64   $��15(�6F   �� 5*   *   $
��Bold"�6J   $��16(�6\   ��64   �� *Name+6\   5+   '   �� 5,   &   $ 
Horizontal=�61   .+�5-   *   �� $��Описание: ��64   $��15(�6F   �� 5.   *   $��16(�6Q   ��64   �� *Description+6Q   5/   '   �� 50   &   $ 
Horizontal=�61   .+�51   *   �� $��Категория: ��64   $��15(�6G   �� 52   *   $��16(�6N   ��64   �� *
Category+6N   53   '   54   #   55      56      57      59      5:      �� 5;   
   $��1��6   $��1��6"    �� TextWrapping$
 Wrap=�6I   $	��140��6]   $��40��6i   ��6/   �� *
TestName+6i   �� 5<   
   $��1��6   $��1��6!   $
��Left=�6/   $��	140,0,0,0q�6J   $��39��6]   $��40��6�   ��6h   �� *SearchTestCommand+.��5=      �� $(��"..\Views\Resource\Image\Search.png��6   	 � ToolTip	 5>      �� 5?      $1��+Поиск по названию теста��6    5A      5B      �� 5C   
   $��1��6   $��2��6!   $��Пройти тест��6.   $��40��6h   $	��170��6t   ��6D   �� *GoToTestCommand+6t   �� 5D   
   $��1��6   $��6��6!   $��
Форум��6.   $��40��6c   $	��170��6o   ��6>   �� *GoToForumCommand+6o   �� 5E   
   $��1��6   $��5��6!   $��Результаты��6.   $��40��6l   $	��170��6x   ��6C   �� *GoToUserTestCommand+6x   �� 5F   
   $��1��6   $��4��6!   $ ��Администратор��6.   $��40��6i   $	��170��6u   ��6F   �� *AddTestCommand+6u   �� 5G   
   $��3��6   $��1��6   $)��#..\Views\Resource\Image\NewPage.png��6-   	 5H      �� 5I      ��6   �� *	Tooltip+5K      5L      5M      