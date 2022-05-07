import React, { useContext, useEffect } from "react";
import { FaqContext } from "../providers/FaqProvider";

const FaqList = () => {
  const { answers, getAllAnswers } = useContext(FaqContext);

  useEffect(() => {
    getAllAnswers();
  }, []);

  return (
    <>
      {answers.map((answer) => (
        <tr key={answer.id}>
            <td>{answer.question.content}</td>
          <td>{answer.content}</td>
        </tr>
      ))}
  </>
  );
};

export default FaqList;