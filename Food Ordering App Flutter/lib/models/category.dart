import 'package:equatable/equatable.dart';

class Category extends Equatable {
  final String name;
  final String imageUrl;

  Category({required this.name, required this.imageUrl});

  @override
  List<Object?> get props => [name, imageUrl];

  static List<Category> categories = [
    Category(
      name: 'BBQ',
      imageUrl:
          'https://images.unsplash.com/photo-1592134073632-f38ffeef9ebd?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwxMTc3M3wwfDF8c2VhcmNofDE2fHxiYnF8ZW58MHx8fHwxNjQ2NDk2MjYy&ixlib=rb-1.2.1&q=80&w=2000',
    ),
    Category(
      name: 'Fast Food',
      imageUrl:
          'https://www.brandsynario.com/wp-content/uploads/2019/02/7-fast-food-joints.jpg',
    ),
    Category(
      name: 'Desi Dishes',
      imageUrl: 'https://i.dawn.com/large/2020/01/5e2173b3cb436.jpg',
    ),
  ];
}
