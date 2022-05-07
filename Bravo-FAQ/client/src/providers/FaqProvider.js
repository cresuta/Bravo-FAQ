import React, { useState } from "react";

export const FaqContext = React.createContext();

export const FaqProvider = (props) => {
  const [questions, setQuestions] = useState([]);
  const [answers, setAnswers] = useState([]);


  // Question api fetch calls
  const getAllQuestions = () => {
    return fetch("/api/question")
      .then((res) => res.json())
      .then(setQuestions);
  };

  const addQuestion = (question) => {
    return fetch("/api/question", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(question),
    });
  };

  const updateQuestion = (question) => {
    return fetch(`/api/question/${question.id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(question)
    })
      .then(getAllQuestions)
  }

  // Answer api fetch calls
  // getAllAnswers can also grab the question it is linked to
  const getAllAnswers = () => {
    return fetch("/api/answer")
      .then((res) => res.json())
      .then(setAnswers);
  };

  const addAnswer = (answer) => {
    return fetch("/api/answer", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(answer),
    });
  };

  const updateAnswer = (answer) => {
    return fetch(`/api/answer/${answer.id}`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(answer)
    })
      .then(getAllAnswers)
  }

  return (
    <FaqContext.Provider value={{ questions, getAllQuestions, addQuestion, updateQuestion, answers, getAllAnswers, addAnswer, updateAnswer }}>
      {props.children}
    </FaqContext.Provider>
  );
};