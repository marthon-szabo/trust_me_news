import React, { useEffect, useContext } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from "axios"
import {ArticleContext, ArticleContextProvider} from "./component/ArticlesContext"

function App() {
    const [articles, setArticles] = useContext(ArticleContext);
    

    useEffect(() => {
        axios.get("https://localhost:44313/reactApi")
        .then((resp) => console.log(resp))
    }, [])

  return (
      <div className="App">
          <ArticleContextProvider>

            </ArticleContextProvider>
    </div>
  );
}

export default App;
