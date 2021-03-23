var  HelloWorld = React.CreateClass({
    render : function(){
        return(
            <div>Hello {this.props.name} </div>
        );
    }
});

React.render(
    <HelloWorld name="World"