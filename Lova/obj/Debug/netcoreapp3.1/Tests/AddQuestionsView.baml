   M S B A M L   `   `   `  ����G  CPresentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentation.ViewModelsPresentation.ViewModels  5      )    #Presentation.Views.AddQuestionsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4vm%clr-namespace:Presentation.ViewModels     5        N� Title$  AddQuestionsView��5	       � DataContext 5      3   -Presentation.ViewModels.AddQuestionsViewModel  5   
    � 	Resources 5       �� Source�� 5   
   $' !..\Views\Resource\Style\Test.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $
��235* �6   �� 5      $
��323* �6   �� 5      $
��242* �6    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��139* �6   �� 5      $	��84* �6   �� 5      $
��187* �6   .+�5   
   �� $��0��6   $��Вопрос��6   $��Stretch=�6.   $��1��6J   �� 5    
   $��1��6   $��Описание:��6!   $��18(�62   $��Center=�6@   $��Center=�6[   �� 5!   
   $��1��6   $��1��6   $	��323��6T   $��90��6`   $��Bottom=�6l    �� TextWrapping$ WrapWithOverflow=�6�   ��6/   �� *QuestionDescription+.��6�    � ToolTip$I CТекст не должен начинаться с пробела��5"   T   .��5#      �� 5$   
   $��2��6   $��Ответ:��6!   $��18(�6/   $��Center=�6=   $��Center=�6X   �� 5%   
   $��2��6   $��1��6   $��50��6G   $	��323��6S   $��Bottom=�6_   $ WrapWithOverflow=�6z   ��6/   �� *Answer+.��6�   $I CТекст не должен начинаться с пробела��5&   T   .��5'      �� 5(   
   $��3��6   $��2��6   $#��Добавить вопрос��62   $	��254��6L   $��51��6X   ��6d   �� *AddQuestionCommand+�� 5)   
   $��2��6   $��3��6!   $��Завершить��6.   $��40��6f   $	��170��6r   ��6B   �� *GoToTestCommand+6r   �� 5*   
   $��2��6   $��1��6    $��2��6-   $%��..\Views\Resource\Image\Add.png��6>   $��
23,0,13,36q�6g   5,      5-      