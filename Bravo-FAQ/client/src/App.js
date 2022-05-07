import React from "react";
import "./App.css";
import { FaqProvider } from "./providers/FaqProvider";
import FaqList from "./components/FaqList";

function App() {
  return (
    <div className="App">
      <FaqProvider>
        <FaqList />
      </FaqProvider>
    </div>
  );
}

export default App;
