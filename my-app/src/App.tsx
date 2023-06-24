import "./App.css";
import {Route, Routes} from "react-router-dom";
import DefaultLayout from "./components/containers/default/DefaultLayout";
import CategoryListPage from "./components/category/list/CategoryListPage";
import CategoryCreatePage from "./components/category/create/CategoryCreatePage";
import LoginPage from "./components/auth/login/LoginPage";
import CategoryEditPage from "./components/category/edit/CategoryEditPage";
import AdminHomePage from "./components/admin/AdminHomePage";

function App() {
    return (
        <>
            <Routes>
                <Route path="/" element={<DefaultLayout/>}>
                    <Route index element={<CategoryListPage/>}/>
                    <Route path={"categories"}>
                        <Route path="create" element={<CategoryCreatePage/>}/>
                        <Route path="edit/:id" element={<CategoryEditPage/>}/>
                    </Route>
                    <Route path="login" element={<LoginPage/>}/>
                </Route>

                <Route path={"/admin"} element={<AdminHomePage/>}/>
            </Routes>
        </>
    );
}

export default App;
