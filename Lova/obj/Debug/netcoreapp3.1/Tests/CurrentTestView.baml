   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      (    "Presentation.Views.CurrentTestView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$
  Test��5	       � DataContext 5      2   ,Presentation.ViewModels.CurrentTestViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $' !..\Views\Resource\Style\Test.xaml?�6   %    .��5      �  � RowDefinitions 5   
   �� 5      $	��38* �6   �� 5      $
��245* �6   �� 5      $
��149* �6    � ColumnDefinitions 5   
   �� 5      $
��577* �6   �� 5      $
��223* �6   .+�5   
   �� $��0��6   $��2��6   ��61   �� *
TestName+R� 5   
   $��1��6   $��1��6    .@�5      Q� $��15(�6   $��Памятка��6)   .@�5       Q� $	��198��6   ��5!      �� 5"      .+�5#      �� $
��Wrap=�6(   $q��k• Тест можно выполнять неопределенное количество времени��6<   6~   �� 5$      $
��Wrap=�6(   $����• Отвечать на вопросы можно в любом порядке, для этого нажмите на вопрос, введите ответ в текстовое поле и сохраните его��6<   �� 5%      $
��Wrap=�6(   $e��_• Менять ответ можно неопределенное количество раз��6<   5&      5(      5)      5*      �� 5,   
   $��1��6   $��0��6    ��60   �� *	Questions+ �� SelectedItem 6R   �� *SelectedQuestion+��5-      �� 5.      .R�5/      �� ���#8570E0$��2q�63    �� Padding$ 10q�6G   $	��550��6T   ._�50      �� $��18(�6$   $
��Wrap=�6O   ��62   �� *Description+6O   51      52      54      �� 56   
   $��0��6   $��3��6"   $	��400��6/   $��50��6;   $	��Top=�6G   ��6_   �� *Answer+ �� Mode$ TwoWay=�.��6�   	 � ToolTip$I	 CТекст не должен начинаться с пробела��57   T   .��58      �� 59   
   $��0��6   $��3��6!   $��Right=�6.   $��50��6J   $	��150��6V   $	��Top=�6b   $#��Сохранить ответ��6�   ��6{   �� *SaveAnswerCommand+6�   �� 5:   
   $��0��6   $��3��6!   $	��300��6.   $��60��6:   $
��Left=�6F   $!��Проверить тест��6�   $	��Top=�6�   $��
140,69,0,0q�6�   ��6a   �� *CheckTestCommand+6�   �� 5;   
   $��1��6   $��3��6!   $��
Форум��6.   $��0,75,0,0q�6c   $	��Top=�6u   $��40��6�   $	��170��6�   ��6>   �� *GoToForumCommand+6�   �� 5<   
   $��1��6   $��3��6!   $��
Тесты��6.   $��0,11,0,0q�6b   $	��Top=�6t   $��40��6�   $	��170��6�   ��6>   �� *GoToTestCommand+6�   5=      5>      