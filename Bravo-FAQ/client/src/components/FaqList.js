import React, { useContext, useEffect } from "react";
import { FaqContext } from "../providers/FaqProvider";

const FaqList = () => {
  const { questions, getAllQuestions } = useContext(FaqContext);

  useEffect(() => {
    getAllQuestions();
  }, []);

  return (
    <div>
      {questions.map((question) => (
        <div key={question.id}>
          <p>{question.content}</p>
        </div>
      ))}
    </div>
  );
};

export default FaqList;