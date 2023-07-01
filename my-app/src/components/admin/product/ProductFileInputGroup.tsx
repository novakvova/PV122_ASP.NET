const ProductFileInputGroup = () => {
    return (
        <>
            <a id="addPhoto" href="javascript:void(0);" className="btn-add-img">
                <svg width="36" height="36" viewBox="0 0 36 36" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <path
                        d="M33 27V11C33 10.4477 32.5523 10 32 10H26.4142C26.149 10 25.8946 9.89464 25.7071 9.70711L24.2929 8.29289C24.1054 8.10536 23.851 8 23.5858 8H12.4142C12.149 8 11.8946 8.10536 11.7071 8.29289L10.2929 9.70711C10.1054 9.89464 9.851 10 9.58579 10H4C3.44772 10 3 10.4477 3 11V27C3 27.5523 3.44772 28 4 28H32C32.5523 28 33 27.5523 33 27Z"
                        stroke="#256799" stroke-width="2"></path>
                    <circle cx="18" cy="18" r="6" stroke="#256799" stroke-width="2"></circle>
                    <circle cx="29" cy="14" r="1" fill="#256799"></circle>
                </svg>
                Додати фото
            </a>
        </>

    );
}
export default ProductFileInputGroup;
