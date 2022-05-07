import React from 'react';
import './App.css';
import { FaqProvider } from './providers/FaqProvider';
import FaqList from './components/FaqList';
// Libraries for Bootstrap and JQuery
import 'bootstrap/dist/css/bootstrap.min.css';
import 'jquery/dist/jquery.min.js';
// Datatable modules
import "datatables.net-dt/js/dataTables.dataTables"
import "datatables.net-dt/css/jquery.dataTables.min.css"
import $ from 'jquery'; 
class App extends React.Component {
  componentDidMount() {
    //initialize datatable
    $('#example').DataTable();
 }

  render(){

  return (
    <div className="MainDiv">
      <div class="jumbotron text-center bg-sky">
          <h3>Frequently Asked Questions</h3>
      </div>
      
      <div className="container">
          
          <table id="example" class="display">
            <thead>
                <tr>
                    <th>Question</th>
                    <th>Answer</th>
                </tr>
            </thead>
            <tbody>
               <FaqList/>
            </tbody>
            <tfoot>
                <tr>
                    <th>Question</th>
                    <th>Answer</th>
                </tr>
            </tfoot>
        </table>
          
        </div>
      </div>
  );
}
}
export default App;
