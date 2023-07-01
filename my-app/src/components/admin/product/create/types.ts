export interface IProductCreate {
    name: string;
    price: number;
    description: string;
    categoryId: number;
    imagesId: number[]; //фото, які треба додать до товару
}
