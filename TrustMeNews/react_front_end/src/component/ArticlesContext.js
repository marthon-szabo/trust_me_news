import React, { useState, createContext } from "react";

export const ArticleContext = createContext();

export function ArticleContextProvider() {
    const [articles, setArticles] = useState([]);

    return (
        <ArticleContext.Provider value={[articles, setArticles]}>
            {props.children}
        </ArticleContext.Provider>
        )
};