const employee={template:`
<h1>Manage Employees</h1>

<table class="table table-striped">
<thead>
    <tr>
        <th>
            Employee Id
        </th>
        <th>
            First Name
        </th>
        <th>
            Last Name
        </th>
        <th>
            Phone Number
        </th>
        <th>
            Address
        </th>
        <th>
            Email
        </th>
        <th>
            Date of Join
        </th>
        <th>
            Date of Birth
        </th>
        <th>
            Department
        </th>
        <th>
        </th>
    </tr>
</thead>
<tbody>
    <tr v-for="e in employees">
        <td>{{e.id}}</td>
        <td>{{e.firstName}}</td>
        <td>{{e.lastName}}</td>
        <td>{{e.phoneNumber}}</td>
        <td>{{e.address}}</td>
        <td>{{e.email}}</td>
        <td>{{e.dateOfJoin}}</td>
        <td>{{e.dateOfBirth}}</td>
        <td>{{e.departmentId}}</td>
        <td>
            <button type="button" class="btn btn-light mr-1"><i class="bi bi-pencil-square"></i>
            </button>&nbsp
            <button type="button" class="btn btn-light mr-1"><i class="bi bi-pencil-square"></i>
            </button>
        </td>
    </tr>
</tbody>
</table>


`,

data(){
    return{
        employees:[],
        modalTitle: "",
    };
},
methods:{
    refreshData(){
        axios.get(variables.API_URL+"employee")
        .then((response)=>{
            this.employees=response.data;
        });
    }
},
mounted:function(){
    this.refreshData();
},
}