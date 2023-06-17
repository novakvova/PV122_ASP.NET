import axios from "axios";
import { APP_ENV } from "./env";

const http = axios.create({
    baseURL: APP_ENV.BASE_URL,  //Налаштовуємо базовий маршрут для усіх запитів (префікс для запитів)
    headers: {
        "Content-Type": "application/json" //Формат даних, який буде вкористовуватися при обміні даних іх сервером
    }
});

export default http;