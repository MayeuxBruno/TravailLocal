   M S B A M L   `   `   `  ����G  CGestionStock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GestionStock.WindowsGestionStock.Windows  5   	   *    $GestionStock.Windows.GestionArticles   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:GestionStock.Windows     5   	     � Title$  Gestion des Articles��5   	   $	��600��6&   $
��1000��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $	��10* �6   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Gestion des Produits��6   $��1��6/   $��1��6<   $��3��6L   $��Center=�6`   $��20(�6�   $
��Bold"�6�   $��Italic$�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgListeArticle��5      $��3��5       $��1��6    $��6��5!         AutoGenerateColumns$ False��5"         
IsReadOnly$
 True��5#         Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ 	IdArticle��6%      
Visibility$ Hidden=�5(   %   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5'   %   �� *	IdArticle+5(   %     5)      $ Libelle de l'article��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 10* 5+   %   	 5*   %   �� *LibelleArticle+5+   %     5,      $ 	Quantité��6%   $
 2* 5.   %   	 5-   %   �� *QuantiteStockee+5.   %     5/      $ IdCategorie��6%   $ Hidden=�51   %   	 50   %   �� *IdCategorie+51   %     52      $ 
Catégorie��6%   $
 5* 54   %   	 53   %   �� *Categ.LibelleCategorie+54   %   56      �� 57   
   -   5         ��Name$ btnAjout��57      $��Ajouter��6#   $��3��66   $��3��6C   6S   �� 58   
   -   5        $ btnModif��58      $��Modifier��6#   $��5��66   $��3��6C   �� 59   
   -   5        $ btnSuppr��59      $��	Supprimer��6#   $��7��67   $��3��6D   �� 5:   
   -   5        $ 	btnRetour��5:      $��Retour��6$   $��9��65   $��3��6B   6R   5<      5=      