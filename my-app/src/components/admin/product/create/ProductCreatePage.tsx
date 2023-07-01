import ProductFileInputGroup from "../ProductFileInputGroup";


const ProductCreatePage = () => {
    return (
        <>
            <h1 className={"text-center"}>Додати товар</h1>
            <div>
                <ProductFileInputGroup field={"image"} />

            </div>
        </>
    );
}

export default ProductCreatePage;
