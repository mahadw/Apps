import 'package:equatable/equatable.dart';

class Product extends Equatable {
  final String name;
  final String category;
  final String imageUrl;
  final double price;
  final bool isRecommended;
  final bool isPopular;

  Product({
    required this.name,
    required this.imageUrl,
    required this.category,
    required this.price,
    required this.isRecommended,
    required this.isPopular,
  });

  @override
  List<Object?> get props => [
        name,
        imageUrl,
        category,
        price,
        isRecommended,
        isPopular,
      ];

  static List<Product> products = [
    Product(
      name: 'Chicken Tikka',
      imageUrl:
          'https://kfoods.com/images1/newrecipeicon/bihari-chicken-tikka-recipe_14539.jpg',
      category: 'BBQ',
      price: 300,
      isRecommended: false,
      isPopular: true,
    ),
    Product(
      name: 'Kabab',
      imageUrl:
          'https://img-global.cpcdn.com/recipes/7d110718912b76e3/640x640sq70/photo.webp',
      category: 'BBQ',
      price: 150,
      isRecommended: true,
      isPopular: true,
    ),
    Product(
      name: 'Zinger',
      imageUrl:
          'https://kfc-menu.co.uk/wp-content/uploads/2022/06/zinger-burger.jpg',
      category: 'Fast Food',
      price: 300,
      isRecommended: false,
      isPopular: true,
    ),
    Product(
      name: 'Chicken Karahi',
      imageUrl:
          'https://www.pakistanihealthyrecipes.com/wp-content/uploads/2021/05/pakistani-chicken-karahi-recipe-1024x683.jpg',
      category: 'Desi Dishes',
      price: 1200,
      isRecommended: false,
      isPopular: true,
    ),
    Product(
      name: 'Mutton Karahi',
      imageUrl:
          'https://carameltintedlife.com/wp-content/uploads/2021/09/karahi-gosht-1-3-1.jpg',
      category: 'Desi Dishes',
      price: 1400,
      isRecommended: true,
      isPopular: true,
    ),
    Product(
      name: 'Broast',
      imageUrl: 'https://hamariweb.com/recipes/images/recipeimages/6575.jpg',
      category: 'Fast Food',
      price: 250,
      isRecommended: false,
      isPopular: true,
    ),
    Product(
      name: 'Dal Makhani',
      imageUrl:
          'https://geekrobocook.com/wp-content/uploads/2021/01/Dal-makhani.jpg',
      category: 'Desi Dishes',
      price: 700,
      isRecommended: true,
      isPopular: true,
    ),
    Product(
      name: 'Club Sandwich',
      imageUrl:
          'https://kfoods.com/images1/newrecipeicon/club-sandwich_483.jpg',
      category: 'Fast Food',
      price: 250,
      isRecommended: false,
      isPopular: true,
    ),
    Product(
      name: 'Beef Bihari Roll',
      imageUrl:
          'https://sp-ao.shortpixel.ai/client/to_auto,q_glossy,ret_img,w_600,h_338/https://www.tandoorihut.com.pk/storage/2014/12/1-27.jpg',
      price: 150,
      category: 'BBQ',
      isRecommended: false,
      isPopular: true,
    ),
  ];
}
